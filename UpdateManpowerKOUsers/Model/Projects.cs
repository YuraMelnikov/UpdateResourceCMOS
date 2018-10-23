using System;
using System.Linq;
using Microsoft.ProjectServer.Client;
using UpdateManpowerKOUsers.ContextExport1c;

namespace UpdateManpowerKOUsers.Model
{
    class Projects : ContextProject
    {
        exportImportEntities _db = new exportImportEntities();


        public void SetPSAMInProjectName()
        {
            projContext.Load(projContext.Projects);
            projContext.ExecuteQuery();
            foreach (PublishedProject pubProj in projContext.Projects)
            {
                DraftProject projectDraft = pubProj.CheckOut();
                try
                {
                    projectDraft.Name += GetRSAMName(Convert.ToInt32(projectDraft.Name.Substring(0, 4)));
                }
                catch 
                {

                }
                QueueJob job = projectDraft.Update();
                job = projectDraft.Publish(true);
            }
        }

        private string GetRSAMName(int numberPlanZakaz)
        {
            string nameRSAM = "";
            nameRSAM = _db.planZakaz.First(d => d.Zakaz == numberPlanZakaz.ToString())?.OboznacIzdelia.Replace(" ", "");
            return nameRSAM;
        }
    }
}
