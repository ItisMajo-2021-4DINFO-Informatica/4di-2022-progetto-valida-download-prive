using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace PrivèValidaDownloadApp
{
    class sha256
    {

        public bool ControlloValori(string sha, string percorso)
        {
            bool uguale = false;
            string shaDaVerificare = "";


            using (FileStream flusso = new FileStream(percorso, FileMode.Open, FileAccess.Read))
            {
                StreamReader reader = new StreamReader(flusso);
                while (!reader.EndOfStream)
                {

                    string linea = reader.ReadLine();
                    string[] elementi = linea.Split(' ');
                    shaDaVerificare = elementi[0];

                }


            }

            if(shaDaVerificare == sha)
            {
                uguale = true;
                
            }
            else
            {
                uguale = false;
            }
            return uguale;
        }




        public string SHA256CheckSum(string filePath)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                using (FileStream lettore = File.OpenRead(filePath))
                {
                    return (BitConverter.ToString(sHA256.ComputeHash(lettore)).Replace("-", "")).ToLower();
                }
            }
        }


        public string openExplorer1(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.Filter = "(*.iso)|*.iso| All files(*.*)| *.*";
            openFile.InitialDirectory = @"C:\Temp\";

            if (openFile.ShowDialog() == true)
            {
                string path = openFile.FileName;
                return path;
            }
            else { return "Errore"; }
        }
        public string openExplorer2(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.Filter = "(*.sha256)|*.sha256| All files(*.*)| *.*";
            openFile.InitialDirectory = @"C:\Temp\";

            if (openFile.ShowDialog() == true)
            {
                string path = openFile.FileName;
                return path;
            }
            else { return "Errore"; }
        }
        public string openExplorer3(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.Filter = "(*.asc)|*.asc| All files(*.*)| *.*";
            openFile.InitialDirectory = @"C:\Temp\";

            if (openFile.ShowDialog() == true)
            {
                string path = openFile.FileName;
                return path;
            }
            else { return "Errore"; }
        }

    }
}
