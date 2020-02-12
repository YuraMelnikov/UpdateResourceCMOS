using UpdateManpowerKOUsers.Model;

namespace UpdateManpowerKOUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCurencyBYN curencyBYN = new NewCurencyBYN();
            Projects prj = new Projects();
            //prj.RenameTasks();
            prj.SetPSAMInProjectName();
            ExcelFile excelFile = new ExcelFile();
            excelFile.UploadDataInListDataInExcel();
            ProjectResourceManpower projectResourceManpower = new ProjectResourceManpower(excelFile.DataInExcel);
            projectResourceManpower.UpdateManpower();
            prj.UpdateCriticalDateClose();
        }
    }
}
