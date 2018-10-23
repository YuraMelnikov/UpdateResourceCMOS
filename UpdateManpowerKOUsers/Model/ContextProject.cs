using Microsoft.ProjectServer.Client;
using System;
using System.Collections.Generic;
using System.Linq;

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
