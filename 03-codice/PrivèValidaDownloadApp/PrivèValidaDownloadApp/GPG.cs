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

        public string VerificaChiamataEsterna(string sha, string asc, string finger, string exe)
        {
         
            string output;

            try
            {

                /* using (Process pProcess = new Process())
                 {
                     //pProcess.StartInfo.FileName = exe;
                     //pProcess.StartInfo.Arguments = "gpg --recv-keys " + finger; //argument
                     //pProcess.StartInfo.UseShellExecute = false;
                     //pProcess.StartInfo.RedirectStandardOutput = true;
                     ////pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                     //pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                     //pProcess.Start();
                     //output = pProcess.StandardOutput.ReadToEnd(); //The output result
                     //pProcess.WaitForExit();
                     pProcess.StartInfo.FileName = "cmd.exe";

                     pProcess.StartInfo.Arguments = "/k gpg --recv-keys 3DBDC284"; //argument
                     pProcess.StartInfo.UseShellExecute = false;
                     pProcess.StartInfo.RedirectStandardOutput = true;
                     pProcess.Start();
                     // Synchronously read the standard output of the spawned process.

                 }



                 using (Process pProcess = new Process())
                 {
                     pProcess.StartInfo.FileName = "cmd.exe";
                     pProcess.StartInfo.Arguments = "/k gpg --verify " +
                         asc + " " + sha; //argument
                     pProcess.StartInfo.UseShellExecute = false;
                     pProcess.StartInfo.RedirectStandardOutput = true;
                     pProcess.Start();
                     StreamReader reader = pProcess.StandardOutput;
                     output = reader.ReadToEnd();
                     pProcess.WaitForExit();

                 }*/

                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.CreateNoWindow = true;
                    pProcess.StartInfo.FileName = "cmd.exe";

                    pProcess.StartInfo.Arguments = "/k gpg --recv-keys " + finger ;
                    //pProcess.StartInfo.Arguments = "/k gpg --verify " + asc + " " + sha;
                    //pProcess.StartInfo.Arguments = "/k ipconfig";


                    pProcess.Start();

                }

                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    pProcess.StartInfo.FileName = "cmd.exe";

                   // pProcess.StartInfo.Arguments = "/k gpg --recv-keys " + finger;
                    pProcess.StartInfo.Arguments = "/k gpg --verify " + asc + " " + sha;
                    //pProcess.StartInfo.Arguments = "/k ipconfig";


                    pProcess.Start();

                    StreamReader streamReader = pProcess.StandardOutput;

                    output = pProcess.StandardOutput.ReadToEnd();
                    pProcess.WaitForExit(); 

                }

            }
            catch (Exception e)
            {
                output = e.Message;
            }

            return output;
        }
    }
}
