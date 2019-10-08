using System;
using System.Linq;
using System.Data.Entity;
using UpdateManpowerKOUsers.Context;

namespace UpdateManpowerKOUsers.Model
{
    public class TEOData
    {
        public double GetRateUSDToYear(int year)
        {
            double rate = 0.0;
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                rate = db.PZ_TEO.Include(d => d.PZ_PlanZakaz).Where(d => d.PZ_PlanZakaz.dataOtgruzkiBP.Year == year).Sum(d => d.Rate);
            }
            return rate;
        }

        public double GetRemainingHSS()
        {
            double hss = 0.0;
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                int id_State = db.DashboardBP_State.First(d => d.active == true).id;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                hss = db.DashboardBP_HSSPO
                    .Where(d => d.id_DashboardBP_State == id_State)
                    .Where(d => d.timeByDay > DateTime.Now)
                    .Sum(d => d.xSsm);
            }
            return hss;
        }

        public double GetHSSToYear(int year)
        {
            double hss = 0.0;
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                int id_State = db.DashboardBP_State.First(d => d.active == true).id;
                db.Configuration.ProxyCreationEnabled = false;
                db.Configuration.LazyLoadingEnabled = false;
                hss = db.DashboardBP_HSSPO
                    .Where(d => d.id_DashboardBP_State == id_State)
                    .Where(d => d.timeByDay.Year == year)
                    .Sum(d => d.xSsm);
            }
            return hss;
        }
    }
}
