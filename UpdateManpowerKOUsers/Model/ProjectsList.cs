using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateManpowerKOUsers.Context;

namespace UpdateManpowerKOUsers.Model
{
    public class ProjectsList
    {
        public bool CreatePZList()
        {
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                var list = db.PZ_PlanZakaz.AsNoTracking().Where(d => d.dataOtgruzkiBP > DateTime.Now && d.ProjectUID != null).ToList();
                int idState = db.DashboardBP_State.AsNoTracking().First(d => d.active == true).id;
                foreach (var data in list)
                {
                    ProjectMSP_EpmProject_UserView projectMSP_EpmProject_UserView = db.ProjectMSP_EpmProject_UserView.First(d => d.ProjectUID == data.ProjectUID);
                    DashboardBP_ProjectList project = new DashboardBP_ProjectList
                    {
                        id_PZ_PlanZakaz = data.Id,
                        id_DashboardBP_State = idState,
                        contractDate = data.DateSupply,
                        planDateComplited = data.dataOtgruzkiBP,
                        planDateStart = projectMSP_EpmProject_UserView.ProjectStartDate.Value,
                        planDuration = (int)projectMSP_EpmProject_UserView.ProjectDuration,
                        planProjectPercentCompleted = projectMSP_EpmProject_UserView.ProjectPercentCompleted.Value
                    };
                    db.DashboardBP_ProjectList.Add(project);
                    db.SaveChanges();
                    new TasksList().CreateTask(data.ProjectUID.Value, project.id);
                }
            }
            return true;
        }
    }
}
