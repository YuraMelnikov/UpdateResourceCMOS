using UpdateManpowerKOUsers.Model;

namespace UpdateManpowerKOUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NewCurencyBYN curencyBYN = new NewCurencyBYN();
            }
            catch
            {
            }
            Projects prj = new Projects();
            ////prj.RenameTasks();
            prj.SetPSAMInProjectName();
            ExcelFile excelFile = new ExcelFile();
            excelFile.UploadDataInListDataInExcel("Расчет коэф. КБМ");
            excelFile.UploadDataInListDataInExcel("Расчет коэф. КБЭ");
            ProjectResourceManpower projectResourceManpower = new ProjectResourceManpower(excelFile.DataInExcel);
            projectResourceManpower.UpdateManpower();
            //prj.UpdateCriticalDateClose();
        }
    }
}
