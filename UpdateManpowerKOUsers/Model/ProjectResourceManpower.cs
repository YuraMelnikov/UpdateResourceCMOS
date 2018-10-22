using Microsoft.ProjectServer.Client;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UpdateManpowerKOUsers.Model
{
    class ProjectResourceManpower
    {
        private const string pwaPath = "http://tpserver/PWA/";
        private static ProjectContext projContext;
        List<DataInExcel> dataInExcel = new List<DataInExcel>();

        public ProjectResourceManpower(List<DataInExcel> dataInExcel)
        {
            this.dataInExcel = dataInExcel;
        }

        public void UpdateManpower()
        {
            projContext = new ProjectContext(pwaPath);
            projContext.Load(projContext.EnterpriseResources);
            projContext.Load(projContext.CustomFields);
            projContext.ExecuteQuery();
            if (projContext.EnterpriseResources.Count > 0)
            {
                foreach (var data in projContext.EnterpriseResources)
                {
                    Console.WriteLine(data.Name);
                    var resId = data.Id;
                    EnterpriseResource res = projContext.EnterpriseResources.GetByGuid(resId);
                    projContext.Load(res);
                    projContext.Load(res.CustomFields);
                    projContext.ExecuteQuery();

                    foreach (var dataExcel in dataInExcel)
                    {
                        if (dataExcel.UserName == res.Name)
                        {
                            if (dataExcel.Month == 1)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Jan");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 2)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Feb");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 3)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Mar");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 4)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Apr");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 5)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "May");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 6)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Yun");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 7)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Yul");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 8)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Aug");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 9)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Sen");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 10)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Okt");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 11)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Now");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            else if (dataExcel.Month == 12)
                            {
                                CustomField cField = projContext.CustomFields.First(c => c.Name == "Dec");
                                res[cField.InternalName] = dataExcel.Data * 100;
                                projContext.EnterpriseResources.Update();
                            }
                            projContext.ExecuteQuery();
                        }
                    }
                }
            }
        }
    }
}
