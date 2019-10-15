using System;
using System.Linq;
using Microsoft.ProjectServer.Client;
using UpdateManpowerKOUsers.ContextExport1c;
using UpdateManpowerKOUsers.Context;
using System.Net;

namespace UpdateManpowerKOUsers.Model
{
    class Projects : ContextProject
    {
        exportImportEntities _db = new exportImportEntities();
        PortalKATEKEntities _dbPortal = new PortalKATEKEntities(); 

        public void SetPSAMInProjectName()
        {
            projContext.Load(projContext.Projects);
            projContext.ExecuteQuery();
            foreach (var pubProj in projContext.Projects)
            {
                int planZakazNumber = 0;
                try
                {
                    planZakazNumber = Convert.ToInt32(pubProj.Name.Substring(0, 4));
                }
                catch
                {
                }
                string rsamName = "";
                if (planZakazNumber > 0)
                {
                    rsamName = GetRSAMName(planZakazNumber).Replace("_", "-");
                }
                if (planZakazNumber > 1156 && rsamName != "" && pubProj.Name.Length == pubProj.Name.Replace("PCAM", "").Length && GetVipusk(planZakazNumber) == false)
                {
                    try
                    {
                        DraftProject projectDraft = pubProj.CheckOut();
                        projContext.Load(projectDraft);
                        projContext.ExecuteQuery();
                        projectDraft.Name += "   " + rsamName;
                        Console.WriteLine(projectDraft.Name);
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
            try
            {
                nameRSAM = _db.planZakaz.First(d => d.Zakaz == numberPlanZakaz.ToString())?.OboznacIzdelia.Replace(" ", "");
            }
            catch
            {

            }
            return nameRSAM;
        }

        private bool GetVipusk(int numberPlanZakaz)
        {
            bool vipusk = true;
            try
            {
                vipusk = (bool) _db.planZakaz.First(d => d.Zakaz == numberPlanZakaz.ToString())?.bitVipusk;
            }
            catch
            {
                vipusk = true;
            }
            return vipusk;
        }

        public void UpdateCriticalDateClose()
        {

            NetworkCredential cred = new NetworkCredential();
            cred.Domain = "KATEK";
            cred.UserName = "myi";
            cred.Password = "123qweASD";
            projContext.Credentials = cred;
            projContext.Load(projContext.Projects);
            projContext.Load(projContext.CustomFields);
            projContext.ExecuteQuery();
            foreach (var pubProj in projContext.Projects)
            {
                int planZakazNumber = 0;
                try
                {
                    planZakazNumber = Convert.ToInt32(pubProj.Name.Substring(0, 4));
                }
                catch
                {

                }
                if (planZakazNumber != 0 && planZakazNumber > 1734)
                {
                    try
                    {
                        Console.WriteLine("Update: {0}",planZakazNumber);
                        PZ_PlanZakaz pZ_PlanZakaz = _dbPortal.PZ_PlanZakaz.First(d => d.PlanZakaz == planZakazNumber);
                        if (pZ_PlanZakaz.dataOtgruzkiBP > DateTime.Now)
                        {
                            DateTime criticalDateClose = _dbPortal.PZ_PlanZakaz.First(d => d.PlanZakaz == planZakazNumber).DateSupply;
                            DraftProject projectDraft = pubProj.CheckOut();
                            projContext.Load(projectDraft);
                            projContext.Load(projectDraft.CustomFields);
                            projContext.ExecuteQuery();
                            CustomField cField = projContext.CustomFields.First(c => c.Name == "CriticalDateClose");
                            projectDraft[cField.InternalName] = criticalDateClose;
                            projectDraft.Update();
                            QueueJob job = projectDraft.Update();
                            job = projectDraft.Publish(true);
                            projContext.ExecuteQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }


        public void RenameTasks()
        {
            var list = _dbPortal.RenameTasksKBM.ToList();


            foreach (var dataList in list)
            {
                var projCollection = projContext.LoadQuery(projContext.Projects.Where(p => p.Name == nameProject));
                projContext.ExecuteQuery();
                PublishedProject project = projCollection.First();
                DraftProject draft = project.CheckOut();
                projContext.Load(draft, p => p.StartDate,
                                    p => p.Description);
                string taskName = _db.PWA_EmpTaskAll.First(d => d.TaskUID == dataList.TaskUID).TaskName;
                projContext.Load(draft.Tasks, dt => dt.Where(t => t.Name == taskName));
                projContext.Load(draft.Assignments, da => da.Where(a => a.Task.Name == taskName));
                projContext.ExecuteQuery();
                DraftTask task = draft.Tasks.First();
                task.ConstraintType = ConstraintType.MustStartOn;
                task.ConstraintStartEnd = dataList.ActualStart;
                draft.Update();
                JobState jobState = context.WaitForQueue(draft.Publish(true), 20);
            }

        }


    }
}
