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


        public string openExplorer(Microsoft.Win32.OpenFileDialog openFile)
        {
            openFile.Filter = "(*.iso)|*.iso";
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
