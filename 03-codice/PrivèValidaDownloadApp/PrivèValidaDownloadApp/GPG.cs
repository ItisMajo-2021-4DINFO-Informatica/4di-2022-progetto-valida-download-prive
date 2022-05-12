using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;



namespace PrivèValidaDownloadApp
{
    class GPG
    {

        public string VerificaChiamataEsterna(string sha, string asc, string finger)
        {
         

            try
            {

                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.CreateNoWindow = true;
                    pProcess.StartInfo.FileName = "cmd.exe";
                    pProcess.StartInfo.Arguments = "/k gpg --recv-keys " + finger ;
                    pProcess.Start();
                    pProcess.WaitForExit(3000);
                }

                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.FileName = "cmd.exe";
                    pProcess.StartInfo.Arguments = "/k gpg --verify " + asc + " " + sha;
                    pProcess.Start();
                    StreamReader streamReader = pProcess.StandardOutput;
                    pProcess.WaitForExit();
                }
                
                return "";

            }
            catch (Exception e)
            {
                return "Errore durante la verifica della firma.";
            }

        }
    }
}
