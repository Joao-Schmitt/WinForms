using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTools.Utils
{
    public class EnergyOptions
    {
        /// <summary>
        /// Seta o modo de energia para desempenho maximo
        /// </summary>
        public static void SetPowerModeMaxPerformance()
        {
            Commands.ExecuteCommand("powercfg /setactive e9a42b02-d5df-448d-aa00-03f14749eb61");
        }
    }
}
