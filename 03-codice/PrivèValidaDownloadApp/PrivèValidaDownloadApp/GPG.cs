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

        public bool VerificaChiamataEsterna(string sha, string asc, string finger)
        {
            string[] percorso1 = sha.Split('\\');
            string percorso = percorso1[3];
            string output;

            bool res = true;

            using (Process pProcess = new Process())
            {
                pProcess.StartInfo.Arguments = "cd " + percorso;
                pProcess.StartInfo.Arguments = "--verify " +
                      sha + " " +
                      asc; 
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                
                pProcess.Start();
                output = pProcess.StandardOutput.ReadToEnd();
                pProcess.WaitForExit();
            }
            return res;
        }
    }
}
