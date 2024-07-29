using System.Diagnostics;

namespace PCTools.Utils
{
    public class DiskOptions
    {
        /// <summary>
        /// Desfragmenta o disco
        /// </summary>
        public static void DiskDefragment(string driveLetter)
        {
            Process process = new Process();
            process.StartInfo.FileName = "defrag";
            process.StartInfo.Arguments = $"{driveLetter} /U /V";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;

            // Inicia o processo e captura a saída
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
        }
    }
}
