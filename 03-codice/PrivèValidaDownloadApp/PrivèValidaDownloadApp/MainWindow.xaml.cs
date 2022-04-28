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
        String[] quattro = { "Seleziona il tuo file (gpg.exe)", "Nessun file selezionato", "" };

        sha256 SHA256;
        GPG gpg;



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
                quattro[1] = "Nessun file selezionato";
                quattro[2] = "";

                PaginaPrima();
                BtnAvanti.IsEnabled = true;
                BtnAvanti.Content = "Avanti";
                BtnImporta.Content = "Seleziona";
                TbRisultato.Text = "";

                


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
                    else if (pagina == "4/4")
                    {
                        string percorso = SHA256.openExplorer4(openFile);

                        quattro[1] = percorso;
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
               
                if(uno[1] != "Nessun file selezionato" && due[1] != "Nessun file selezionato" && tre[1] != "Nessun file selezionato" && quattro[1] != "Nessun file selezionato" && quattro[2] != "")
                {
                    string sha256 = (SHA256.SHA256CheckSum(uno[1]));
                    MessageBox.Show(sha256);
                    bool check256 = SHA256.ControlloValori(sha256, due[1]);
                    MessageBox.Show(gpg.VerificaChiamataEsterna(due[1], tre[1], quattro[2], quattro[1]));
                    //bool firmato = gpg.VerificaChiamataEsterna(due[1], tre[1], finger);
                    bool firmato = false;
                    MessageBox.Show(check256.ToString());

                    if(check256 == true && firmato == true)
                    {
                        TbRisultato.Text = "Il tuo file è sicuro";
                        LblImporta.Text = "Il checksum SHA256 e la firma digitale del tuo file sono corretti.";
                    }
                    else if(check256 == true)
                    {
                        TbRisultato.Text = "Il tuo file NON è sicuro";
                        LblImporta.Text = "Il checksum SHA256 è corretto, ma la firma digitale del tuo file NON corrisponde.";
                    }
                    else if (firmato == true)
                    {
                        TbRisultato.Text = "Il tuo file NON è sicuro";
                        LblImporta.Text = "La firma digitale corrisponde, ma il checksum SHA256 del tuo file NON è corretto.";
                    }
                    else
                    {
                        TbRisultato.Text = "Il tuo file NON è sicuro";
                        LblImporta.Text = "Il checksum SHA256 e la firma digitale del tuo file NON sono corretti.";
                    }




                    lblIndice.Content = "Fine";
                    BtnAvanti.IsEnabled = false;
                    BtnIndietro.IsEnabled = false;
                    BtnImporta.Content = "Ripristina";
                    lblFile.Content = "";
                    lblFinger.Content = "";
                    txtFinger.Text = "";
                    txtFinger.BorderBrush = Brushes.Transparent;
                    txtFinger.IsEnabled = false;
                    pbProgress.Value = 100;

                }
                else
                {
                    MessageBox.Show("ATTENZIONE! Inserire tutti i file richiesti.");

                }



                
            }




            string pagina = (string)lblIndice.Content;
           if(pagina == "1/4")
            {
                lblIndice.Content = "2/4";
                LblImporta.Text = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 25;
                BtnIndietro.IsEnabled = true;

           }
           else if(pagina == "2/4")
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
                lblFinger.Content = "Inserisci la Finger del file:";
                txtFinger.BorderBrush = Brushes.White;
                txtFinger.IsEnabled = true;
                txtFinger.Text = quattro[2];
                BtnAvanti.Content = "Esegui";
            }



        }


        public void PaginaPrima()
        {
            lblIndice.Content = "1/4";
            LblImporta.Text = uno[0];
            lblFile.Content = uno[1];
            pbProgress.Value = 0;
            BtnIndietro.IsEnabled = false;
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
                pbProgress.Value = 33;
            }
            else if (pagina == "4/4")
            {
                quattro[2] = txtFinger.Text;
                
                lblIndice.Content = "3/4";
                LblImporta.Text = tre[0];
                lblFile.Content = tre[1];
                pbProgress.Value = 50;
                lblFinger.Content = "";
                txtFinger.Text = "";
                txtFinger.BorderBrush = Brushes.Transparent;
                txtFinger.IsEnabled = false;
                BtnAvanti.Content = "Avanti";
            }
        }
    }
}
