using System.Timers;
using UpdateManpowerKOUsers.Model;

namespace UpdateManpowerKOUsers
{
    class Program
    {
        private static Timer aTimer;

        static void Main(string[] args)
        {
            Projects prj = new Projects();
            prj.SetPSAMInProjectName();
            ExcelFile excelFile = new ExcelFile();
            excelFile.UploadDataInListDataInExcel();
            ProjectResourceManpower projectResourceManpower = new ProjectResourceManpower(excelFile.DataInExcel);
            projectResourceManpower.UpdateManpower();
            prj.UpdateCriticalDateClose();
        }
    }
}
