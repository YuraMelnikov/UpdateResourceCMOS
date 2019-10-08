using System.Linq;
using UpdateManpowerKOUsers.Context;

namespace UpdateManpowerKOUsers.Model
{
    public class RemainingHSS
    {
        private readonly double plan = 3000000.0;

        public void CreateNew()
        {
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                DashboardRemaining remainingHss = new DashboardRemaining
                {
                    plan = plan,
                    id_DashboardBP_State = db.DashboardBP_State.First(d => d.active == true).id,
                    hss = new TEOData().GetRemainingHSS()
                };
                db.DashboardRemaining.Add(remainingHss);
                db.SaveChanges();
            }
        }
    }
}
