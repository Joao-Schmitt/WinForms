using Microsoft.Win32;

namespace PCTools.Utils
{
    public class BootOptions
    {
        /// <summary>
        /// Seta o maior número de processadores na inicialização
        /// </summary>
        public static void SetTheHighestProcessors()
        {
            var processorCount = Environment.ProcessorCount;
            Commands.ExecuteCommand($"bcdedit /set {Guid.NewGuid()} numproc {processorCount}");
        }

        /// <summary>
        /// Desabilita os programas que inicializam com o Windows pelo Registro
        /// </summary>
        public static void DisableStartupProgramsInRegistry()
        {
            string[] registryKeys = {
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                @"SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce",
                @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Run",
                @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\RunOnce"
            };

            foreach (string keyPath in registryKeys)
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        foreach (string valueName in key.GetValueNames())
                        {
                            key.DeleteValue(valueName);
                        }
                    }
                }

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyPath, true))
                {
                    if (key != null)
                    {
                        foreach (string valueName in key.GetValueNames())
                        {
                            key.DeleteValue(valueName);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Desabilita os programas que inicializam com o Windows pela pasta de inicialização
        /// </summary>
        public static void DisableStartupProgramsInStartupFolder()
        {
            string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string commonStartupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);

            DirectoryInfo directoryInfo = new DirectoryInfo(startupFolderPath);
            foreach (FileInfo file in directoryInfo.GetFiles())
                file.Delete();


            directoryInfo = new DirectoryInfo(commonStartupFolderPath);
            foreach (FileInfo file in directoryInfo.GetFiles())
                file.Delete();
        }
    }
}
