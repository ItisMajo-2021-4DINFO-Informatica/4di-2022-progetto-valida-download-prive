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

                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.FileName = exe;
                    pProcess.StartInfo.Arguments = "gpg --recv-keys " + finger; //argument
                    pProcess.StartInfo.UseShellExecute = false;
                    //pProcess.StartInfo.RedirectStandardOutput = true;
                    //pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                    pProcess.Start();
                    //output = pProcess.StandardOutput.ReadToEnd(); //The output result
                    pProcess.WaitForExit();
                }



                using (Process pProcess = new Process())
                {
                    pProcess.StartInfo.FileName = exe;
                    pProcess.StartInfo.Arguments = "gpg --verify " +
                        asc + " " + sha; //argument
                    pProcess.StartInfo.UseShellExecute = false;
                    pProcess.StartInfo.RedirectStandardOutput = true;
                    //pProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    //pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                    pProcess.Start();
                    output = pProcess.StandardOutput.ReadToEnd(); //The output result
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
