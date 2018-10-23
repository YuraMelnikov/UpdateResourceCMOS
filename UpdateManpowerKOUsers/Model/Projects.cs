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
            foreach (PublishedProject pubProj in projContext.Projects.Where(d => d.PercentComplete < 100))
            {
                if (pubProj.Name.Length == pubProj.Name.Replace("PCAM", "").Length)
                {
                    try
                    {
                        string rsamName = GetRSAMName(Convert.ToInt32(pubProj.Name.Substring(0, 4)));
                        DraftProject projectDraft = pubProj.CheckOut();
                        projectDraft.Name += rsamName;
                        QueueJob job = projectDraft.Update();
                        job = projectDraft.Publish(true);
                    }
                    catch { }
                }
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
