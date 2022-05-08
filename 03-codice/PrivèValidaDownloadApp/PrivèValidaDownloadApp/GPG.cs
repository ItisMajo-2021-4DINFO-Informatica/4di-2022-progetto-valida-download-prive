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

        public void VerificaChiamataEsterna(string sha, string asc, string finger)
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
                    pProcess.WaitForExit(1000);
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

            }
            catch (Exception e)
            {
            }

        }
    }
}
