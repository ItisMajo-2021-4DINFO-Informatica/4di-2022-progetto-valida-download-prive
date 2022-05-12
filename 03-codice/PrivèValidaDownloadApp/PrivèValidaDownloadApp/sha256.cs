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

        public bool ControlloValori(string path, string percorso)
        {
            string shaCalcolato = SHA256CheckSum(path);

            bool uguale = false;
            string shaDaVerificare = "";

            try
            {
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

                if (shaDaVerificare == shaCalcolato)
                {
                    uguale = true;
                }
                else
                {
                    uguale = false;
                }
            }
            catch(Exception exp)
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
                    return((BitConverter.ToString(sHA256.ComputeHash(lettore)).Replace("-", "")).ToLower());
                }
            }

            

        }


        public string openExplorer1(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.Filter = "(*.iso)|*.iso| All files(*.*)| *.*";
            return ApriDialogo(openFile);

        }
        public string openExplorer2(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.Filter = "(*.sha256)|*.sha256| All files(*.*)| *.*";
            return ApriDialogo(openFile);

        }
        public string openExplorer3(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.Filter = "(*.asc)|*.asc| All files(*.*)| *.*";
            return ApriDialogo(openFile);
            
        }
        

        public string ApriDialogo(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.InitialDirectory = @"C:\Temp\";

            if (openFile.ShowDialog() == true)
            {
                string path = openFile.FileName;
                return path;
            }
            else { return "Nessun file selezionato"; }
        }

    }
}
