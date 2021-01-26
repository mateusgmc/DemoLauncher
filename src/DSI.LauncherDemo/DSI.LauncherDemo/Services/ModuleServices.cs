using DSI.LauncherDemo.Models;
using System.Diagnostics;

namespace DSI.LauncherDemo.Services
{
    public class ModuleServices : IModuleServices
    {
        public void OpenModule(Module module)
        {
            using (Process.Start(module.Path))
            {
            }
        }
    }
}
