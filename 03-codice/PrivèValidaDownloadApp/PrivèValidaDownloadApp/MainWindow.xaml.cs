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
        sha256 SHA256;



        public MainWindow()
        {
            InitializeComponent();
            SHA256 = new sha256();

        }

        private void BtnImporta_Click(object sender, RoutedEventArgs e)
        {
            if(BtnImporta.Content == "Ripristina")
            {
                uno[1] = "Nessun file selezionato";
                due[1] = "Nessun file selezionato";
                tre[1] = "Nessun file selezionato";
                PaginaPrima();
                BtnAvanti.IsEnabled = true;
                BtnAvanti.Content = "Avanti";
                BtnImporta.Content = "Seleziona";
                


            }
            else
            {
                Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog();
                string percorso =   SHA256.openExplorer(openFile);
                string pagina = (string)lblIndice.Content;
                {
                    if(pagina == "1/3")
                    {
                        uno[1] = percorso;
                        lblFile.Content = percorso;


                    }
                    else if(pagina == "2/3")
                    {
                        due[1] = percorso;
                        lblFile.Content = percorso;


                    }
                    else if(pagina == "3/3")
                    {
                        tre[1] = percorso;
                        lblFile.Content = percorso;

                    }
                }



            }


        }

        

       
        private void BtnAvanti_Click(object sender, RoutedEventArgs e)
        {
            if(BtnAvanti.Content == "Esegui")
            {
                MessageBox.Show(SHA256.SHA256CheckSum(uno[1]));
                     
                
                lblIndice.Content = "Fine";
                BtnAvanti.IsEnabled = false;
                BtnIndietro.IsEnabled = false;
                LblImporta.Content = "Inserire gli errori trovati";
                BtnImporta.Content = "Ripristina";
                lblFile.Content = "";
                pbProgress.Value = 100;
            }




            string pagina = (string)lblIndice.Content;
           if(pagina == "1/3")
            {
                lblIndice.Content = "2/3";
                LblImporta.Content = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 33;
                BtnIndietro.IsEnabled = true;

           }
           if(pagina == "2/3")
            {
                lblIndice.Content = "3/3";
                LblImporta.Content = tre[0];
                lblFile.Content = tre[1];
                pbProgress.Value = 66;
                BtnAvanti.Content = "Esegui";
            }
           


        }


        public void PaginaPrima()
        {
            lblIndice.Content = "1/3";
            LblImporta.Content = uno[0];
            lblFile.Content = uno[1];
            pbProgress.Value = 0;
            BtnIndietro.IsEnabled = false;
        }


        private void BtnIndietro_Click(object sender, RoutedEventArgs e)
        {
            string pagina = (string)lblIndice.Content;

            if (pagina == "2/3")
            {
                PaginaPrima();
            }
            if (pagina == "3/3")
            {
                lblIndice.Content = "2/3";
                LblImporta.Content = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 33;
                BtnAvanti.Content = "Avanti";
            }
        }
    }
}
