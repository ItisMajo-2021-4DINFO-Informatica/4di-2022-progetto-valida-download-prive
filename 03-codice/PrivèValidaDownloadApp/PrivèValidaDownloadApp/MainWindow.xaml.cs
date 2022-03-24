using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;

namespace PrivèValidaDownloadApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String[] uno = { "Seleziona il tuo file (.iso)", "Nessun file selezionato" };
        String[] due = { "Seleziona il tuo file (.sha256)", "Nessun file selezionato" };
        String[] tre = { "Seleziona il tuo file (.asc)", "Nessun file selezionato" };



        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnImporta_Click(object sender, RoutedEventArgs e)
        {
            if(BtnImporta.Content == "Ripristina")
            {
                PaginaPrima();
                BtnAvanti.IsEnabled = true;
                BtnAvanti.Content = "Avanti";
                BtnImporta.Content = "Seleziona";
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "(*.iso)|*.iso";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (openFileDialog.ShowDialog() == true)
                {
                    foreach (string filename in openFileDialog.FileNames)
                    {
                        lblFile.Content = System.IO.Path.GetFileName(filename);
                        uno[1] = System.IO.Path.GetFileName(filename);
                    }
                }
            }
            
            
        }


        public string SHA256CheckSum(string filePath)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                using (FileStream lettore = File.OpenRead(filePath))
                {
                    return BitConverter.ToString(sHA256.ComputeHash(lettore));
                }
            }
        }

        private void BtnAvanti_Click(object sender, RoutedEventArgs e)
        {
            if(BtnAvanti.Content == "Esegui")
            {
                MessageBox.Show(SHA256CheckSum(uno[1]));
                     
                
                lblIndice.Content = "Fine";
                BtnAvanti.IsEnabled = false;
                BtnIndietro.IsEnabled = false;
                LblImporta.Content = "Inserire gli errori trovati";
                BtnImporta.Content = "Ripristina";
                lblFile.Content = "";
                pbProgress.Value = 100;
            }




            string pagina = (string)lblIndice.Content;
           if(pagina == "1.")
            {
                lblIndice.Content = "2.";
                LblImporta.Content = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 33;
                BtnIndietro.IsEnabled = true;
           }
           if(pagina == "2.")
            {
                lblIndice.Content = "3.";
                LblImporta.Content = tre[0];
                lblFile.Content = tre[1];
                pbProgress.Value = 66;
                BtnAvanti.Content = "Esegui";
            }
           


        }


        public void PaginaPrima()
        {
            lblIndice.Content = "1.";
            LblImporta.Content = uno[0];
            lblFile.Content = uno[1];
            pbProgress.Value = 0;
            BtnIndietro.IsEnabled = false;
        }


        private void BtnIndietro_Click(object sender, RoutedEventArgs e)
        {
            string pagina = (string)lblIndice.Content;

            if (pagina == "2.")
            {
                PaginaPrima();
            }
            if (pagina == "3.")
            {
                lblIndice.Content = "2.";
                LblImporta.Content = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 33;
                BtnAvanti.Content = "Avanti";
            }
        }
    }
}
