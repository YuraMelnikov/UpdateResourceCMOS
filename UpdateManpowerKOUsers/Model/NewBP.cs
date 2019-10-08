namespace UpdateManpowerKOUsers.Model
{
    public class NewBP
    {
        public NewBP()
        {
            new ProjectsList().CreatePZList();
            new RatePlan().CreateNewRatePlan();
            new RemainingHSS().CreateNew();
            new HssPlan().CreateNew();
        }
    }
}
