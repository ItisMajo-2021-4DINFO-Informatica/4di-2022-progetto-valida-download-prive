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
        String[] quattro = { "Inserisci la Finger del file", "", "" };

        sha256 SHA256;
        GPG gpg;
        bool check256;
        bool firmato;



        public MainWindow()
        {
            InitializeComponent();
            SHA256 = new sha256();
            gpg = new GPG();
            

        }

        private void BtnImporta_Click(object sender, RoutedEventArgs e)
        {
            if(BtnImporta.Content == "Ripristina")
            {
                uno[1] = "Nessun file selezionato";
                due[1] = "Nessun file selezionato";
                tre[1] = "Nessun file selezionato";
                quattro[1] = "";
                quattro[2] = "";

                PaginaPrima();
                
            }
            else
            {
                Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog();
                string pagina = (string)lblIndice.Content;
                {
                    if(pagina == "1/4")
                    {
                        string percorso = SHA256.openExplorer1(openFile);
                        uno[1] = percorso;
                        lblFile.Content = percorso;


                    }
                    else if(pagina == "2/4")
                    {
                        string percorso = SHA256.openExplorer2(openFile);
                        due[1] = percorso;
                        lblFile.Content = percorso;


                    }
                    else if(pagina == "3/4")
                    {
                        string percorso = SHA256.openExplorer3(openFile);
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
                quattro[2] = txtFinger.Text;
               
                if(uno[1] != "Nessun file selezionato" && due[1] != "Nessun file selezionato" && tre[1] != "Nessun file selezionato" && quattro[2] != "")
                {
                    string sha256 = (SHA256.SHA256CheckSum(uno[1]));
                    check256 = SHA256.ControlloValori(sha256, due[1]);
                    gpg.VerificaChiamataEsterna(due[1], tre[1], quattro[2]);
                    
                    LblImporta.Text = "La firma verificata è corretta?";     
                    RbNO.Visibility = Visibility.Visible;
                    RbSI.Visibility = Visibility.Visible;
                    lblIndice.Content = "Fine";
                    BtnAvanti.IsEnabled = false;
                    BtnIndietro.IsEnabled = false;
                    BtnImporta.Content = "Ripristina";
                    lblFile.Content = "";
                    txtFinger.Visibility = Visibility.Hidden;
                    pbProgress.Value = 100;

                }
                else
                {
                    MessageBox.Show("ATTENZIONE! Inserire tutti gli elementi richiesti.");

                }



                
            }
            else
            {
                string pagina = (string)lblIndice.Content;
                if (pagina == "1/4")
                {
                    lblIndice.Content = "2/4";
                    LblImporta.Text = due[0];
                    lblFile.Content = due[1];
                    pbProgress.Value = 25;
                    BtnIndietro.IsEnabled = true;

                }
                else if (pagina == "2/4")
                {
                    lblIndice.Content = "3/4";
                    LblImporta.Text = tre[0];
                    lblFile.Content = tre[1];
                    pbProgress.Value = 50;
                }
                else if (pagina == "3/4")
                {
                    lblIndice.Content = "4/4";
                    LblImporta.Text = quattro[0];
                    lblFile.Content = quattro[1];
                    pbProgress.Value = 75;
                    txtFinger.Visibility = Visibility.Visible;
                    txtFinger.Text = quattro[2];
                    BtnAvanti.Content = "Esegui";
                    BtnImporta.Visibility = Visibility.Hidden;
                }

            }

        }


        public void PaginaPrima()
        {
            lblIndice.Content = "1/4";
            LblImporta.Text = uno[0];
            lblFile.Content = uno[1];
            pbProgress.Value = 0;
            BtnAvanti.Content = "Avanti";
            BtnImporta.Content = "Seleziona";
            TbRisultato.Text = "";
            BtnImporta.Visibility = Visibility.Visible;
            txtFinger.Visibility = Visibility.Hidden;
            BtnIndietro.IsEnabled = false;
            BtnAvanti.IsEnabled = true;
        }


        public void Controlli()
        {
            RbNO.Visibility = Visibility.Hidden;
            RbSI.Visibility = Visibility.Hidden;
            BtnImporta.Visibility = Visibility.Visible;

            if (check256 == true && firmato == true)
            {
                TbRisultato.Text = "Il tuo file è sicuro";
                LblImporta.Text = "✔ checksum SHA256     ✔ firma digitale";
            }
            else if (check256 == true)
            {
                TbRisultato.Text = "Il tuo file NON è sicuro";
                LblImporta.Text = "✔ checksum SHA256     ✘ firma digitale";
            }
            else if (firmato == true)
            {
                TbRisultato.Text = "Il tuo file NON è sicuro";
                LblImporta.Text = "✘ checksum SHA256     ✔ firma digitale";
            }
            else
            {
                TbRisultato.Text = "Il tuo file NON è sicuro";
                LblImporta.Text = "✘ checksum SHA256     ✘ firma digitale";
            }

        }

        private void BtnIndietro_Click(object sender, RoutedEventArgs e)
        {
            string pagina = (string)lblIndice.Content;

            if (pagina == "2/4")
            {
                PaginaPrima();
            }
            else if (pagina == "3/4")
            {
                lblIndice.Content = "2/4";
                LblImporta.Text = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 25;
            }
            else if (pagina == "4/4")
            {
                lblIndice.Content = "3/4";
                quattro[2] = txtFinger.Text;
                LblImporta.Text = tre[0];
                lblFile.Content = tre[1];
                pbProgress.Value = 50;
                txtFinger.Visibility = Visibility.Hidden;
                BtnAvanti.Content = "Avanti";
                BtnImporta.Visibility = Visibility.Visible;

            }
        }

       

        private void RbSI_Click(object sender, RoutedEventArgs e)
        {

            firmato = true;
            Controlli();
        }

        private void RbNO_Click(object sender, RoutedEventArgs e)
        {

            firmato = false;
            Controlli();
        }
    }
}
