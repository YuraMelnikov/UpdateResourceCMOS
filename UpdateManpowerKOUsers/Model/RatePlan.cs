using System;
using System.Linq;
using UpdateManpowerKOUsers.Context;

namespace UpdateManpowerKOUsers.Model
{
    public class RatePlan
    {
        readonly double plan = 16500000.0;

        public void CreateNewRatePlan()
        {
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                DashboardRatePlan dashboardRatePlan = new DashboardRatePlan
                {
                    plan = plan,
                    id_DashboardBP_State = db.DashboardBP_State.First(d => d.active == true).id,
                    rate = new TEOData().GetRateUSDToYear(DateTime.Now.Year)
                };
                db.DashboardRatePlan.Add(dashboardRatePlan);
                db.SaveChanges();
            }
        }
    }
}
