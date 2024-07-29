using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTools.Utils
{
    public static class Commands
    {
        public static Output ExecuteCommand(string command)
        {
            return ExecuteCommand("/c " + command, "cmd.exe");
        }
        public static Output ExecuteCommand(string command, string program)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo(program, command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                Verb = "runas" //administrador
            };

            var output = new Output();

            using (Process process = Process.Start(processInfo))
            {
                process.OutputDataReceived += (sender, e) => output.Message = e.Data;
                process.BeginOutputReadLine();
                process.ErrorDataReceived += (sender, e) => output.Error = e.Data;
                process.BeginErrorReadLine();
                process.WaitForExit();
            }

            return output;
        }
    }

    public class Output
    {
        public string Message { get; set; }
        public string Error { get; set; }
    }
}
