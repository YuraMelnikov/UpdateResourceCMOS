using System;
using System.IO;
using System.Linq;
using System.Net;
using UpdateManpowerKOUsers.Context;

namespace UpdateManpowerKOUsers.Model
{
    class NewCurencyBYN
    {
        string firstPath = "http://www.nbrb.by/api/exrates/rates/145?onDate=";
        string lastPath = "&Periodicity=0";

        public NewCurencyBYN()
        {
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                DateTime lastDateCurrency = db.CurencyBYN.Max(d => d.date);
                DateTime lastPoin = DateTime.Now.AddDays(-2);
                if(lastDateCurrency < DateTime.Now)
                {
                    for (DateTime i = lastDateCurrency.AddDays(1); lastDateCurrency < lastPoin; i = i.AddDays(1))
                    {
                        string dateForPath = i.Year.ToString() + "-" + i.Month.ToString() + "-" + i.Day.ToString();
                        var httpWebRequest = (HttpWebRequest)WebRequest.Create(firstPath + dateForPath + lastPath);
                        httpWebRequest.ContentType = "text/json";
                        httpWebRequest.Method = "GET";//Можно GET
                        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        var streamReader = new StreamReader(httpResponse.GetResponseStream());
                        var result = streamReader.ReadToEnd();
                        CurencyBYN curencyBYN = new CurencyBYN();
                        curencyBYN.date = i;
                        string curencyString = result.Substring(result.IndexOf("OfficialRate\":") + 14).Replace("}", "").Replace(".", ",");
                        curencyBYN.USD = Convert.ToDouble(curencyString);
                        db.CurencyBYN.Add(curencyBYN);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
