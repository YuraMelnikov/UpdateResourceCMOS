﻿using System;
using System.Data.Entity;
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

                if (planZakazNumber > 1156 && planZakazNumber > 0 && pubProj.Name.Length == pubProj.Name.Replace("PCAM", "").Length && GetVipusk(planZakazNumber) == false)
                {
                    try
                    {
                        string rsamName = GetRSAMName(Convert.ToInt32(pubProj.Name.Substring(0, 4)));
                        DraftProject projectDraft = pubProj.CheckOut();
                        projContext.Load(projectDraft);
                        projContext.ExecuteQuery();
                        projectDraft.Name += "   " + rsamName.Replace("_", "-");
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
    }
}