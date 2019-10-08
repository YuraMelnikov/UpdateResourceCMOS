using System;

namespace UpdateManpowerKOUsers.Model
{
    public class NewBP
    {
        public NewBP()
        {
            new ProjectsList().CreatePZList();
            Console.WriteLine("ProjectsList");
            new RatePlan().CreateNewRatePlan();
            Console.WriteLine("RatePlan");
            new RemainingHSS().CreateNew();
            Console.WriteLine("RemainingHSS");
            new HssPlan().CreateNew();
            Console.WriteLine("HssPlan");
        }
    }
}
