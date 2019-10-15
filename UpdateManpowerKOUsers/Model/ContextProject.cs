using Microsoft.ProjectServer.Client;

namespace UpdateManpowerKOUsers.Model
{
    class ContextProject
    {
        private const string pwaPath = "http://tpserver/PWA/";
        protected static ProjectContext projContext;

        public ContextProject()
        {
            projContext = new ProjectContext(pwaPath);
        }
    }
}
