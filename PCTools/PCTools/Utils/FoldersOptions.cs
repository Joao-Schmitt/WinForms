using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTools.Utils
{
    public class FoldersOptions
    {
        /// <summary>
        /// Limpa os arquivos temporarios
        /// </summary>
        public static void ClearTempFolder()
        {
            var tempPath = Path.GetTempPath();

            // Excluir arquivos na pasta Temp
            foreach (string file in Directory.GetFiles(tempPath))
            {
                try
                {
                    File.Delete(file);
                }
                catch
                {
                    continue;
                }
            }

            // Exclui diretorios na pasta Temp
            foreach (string directory in Directory.GetDirectories(tempPath))
            {
                try
                {
                    Directory.Delete(directory, true);
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}
