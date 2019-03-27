using UpdateManpowerKOUsers.Model;

namespace UpdateManpowerKOUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.UploadDataInListDataInExcel();
            ProjectResourceManpower projectResourceManpower = new ProjectResourceManpower(excelFile.DataInExcel);
            projectResourceManpower.UpdateManpower();
            Projects prj = new Projects();
            prj.SetPSAMInProjectName();
            prj.UpdateCriticalDateClose();
        }
    }
}
