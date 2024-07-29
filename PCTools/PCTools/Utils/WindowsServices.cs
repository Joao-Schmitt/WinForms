using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace PCTools.Utils
{
    public class WindowsServices
    {
        public static void DisableWindowsUpdate()
        {
            // Parar o serviço do Windows Update
            using (ServiceController sc = new ServiceController("wuauserv"))
            {
                if (sc.Status != ServiceControllerStatus.Stopped)
                {
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
                }
            }

            // Desabilita o serviço do Windows Update
            Commands.ExecuteCommand("config wuauserv start= disabled", "sc.exe");
        }

        public static void DisableWindowsSearch()
        {
            // Parar o serviço do Windows Search
            //using (ServiceController sc = new ServiceController("wuauserv"))
            //{
            //    if (sc.Status != ServiceControllerStatus.Stopped)
            //    {
            //        sc.Stop();
            //        sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
            //    }
            //}

            //// Desabilita o serviço do Windows Search
            //Commands.ExecuteCommand("config wuauserv start= disabled", "sc.exe");
        }
    }
}
