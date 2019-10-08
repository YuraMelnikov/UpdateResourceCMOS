using System;
using System.Linq;
using UpdateManpowerKOUsers.Context;

namespace UpdateManpowerKOUsers.Model
{
    public class TasksList
    {
        public bool CreateTask(Guid projectUID, int id_DashboardBP_ProjectList)
        {
            using (PortalKATEKEntities db = new PortalKATEKEntities())
            {
                db.Configuration.AutoDetectChangesEnabled = false;
                var tasksBPList = db.ProjectTask.AsNoTracking().Where(d => d.isActiveBP).ToList();
                foreach (ProjectTask dataBP in tasksBPList)
                {
                    int counterCorrect = db.PWA_TasksForBP.AsNoTracking().Where(d => d.TaskWBS == dataBP.id_TASK_WBS && d.ProjectUID == projectUID).Count();
                    if (counterCorrect > 0)
                    {
                        PWA_TasksForBP taskPWA = db.PWA_TasksForBP.AsNoTracking().First(d => d.TaskWBS == dataBP.id_TASK_WBS && d.ProjectUID == projectUID);
                        DashboardBP_TasksList task = new DashboardBP_TasksList
                        {
                            id_ProjectTask = dataBP.id,
                            id_DashboardBP_ProjectList = id_DashboardBP_ProjectList,
                            startDate = taskPWA.TaskStartDate.Value,
                            finishDate = taskPWA.TaskFinishDate.Value,
                            duration = (double)taskPWA.TaskDuration,
                            work = (double)taskPWA.TaskWork,
                            actualWork = (double)taskPWA.TaskActualWork,
                            remainingWork = (double)taskPWA.TaskRemainingWork,
                            percentCompleted = (double)taskPWA.TaskPercentCompleted,
                            percentWorkCompleted = (double)taskPWA.TaskPercentWorkCompleted,
                            isCritical = taskPWA.TaskIsCritical.Value,
                            priority = (int)taskPWA.TaskPriority
                        };
                        try
                        {
                            task.bStartDate = taskPWA.TaskBaseline0StartDate.Value;
                            task.bFinishDate = taskPWA.TaskBaseline0FinishDate.Value;
                            task.bWork = (double)taskPWA.TaskBaseline0Work;
                            task.bDuration = (double)taskPWA.TaskBaseline0Duration;
                        }
                        catch
                        {

                        }
                        try
                        {
                            task.id_AspNetUsers = db.AspNetUsers.First(d => d.ResourceUID == taskPWA.ResourceUID).Id;
                        }
                        catch
                        {

                        }
                        try
                        {
                            task.deadline = taskPWA.TaskDeadline.Value;
                        }
                        catch
                        {
                            task.deadline = null;
                        }
                        db.DashboardBP_TasksList.Add(task);
                    }
                }
                db.SaveChanges();
                db.ChangeTracker.DetectChanges();
            }
            return true;
        }
    }
}
