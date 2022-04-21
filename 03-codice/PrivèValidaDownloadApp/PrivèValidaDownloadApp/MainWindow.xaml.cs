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
        string finger = "3DBDC284";
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
                    if(pagina == "1/3")
                    {
                        string percorso = SHA256.openExplorer1(openFile);
                        uno[1] = percorso;
                        lblFile.Content = percorso;


                    }
                    else if(pagina == "2/3")
                    {
                        string percorso = SHA256.openExplorer2(openFile);

                        due[1] = percorso;
                        lblFile.Content = percorso;


                    }
                    else if(pagina == "3/3")
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
               
                if(uno[1] != "Nessun file selezionato" && due[1] != "Nessun file selezionato" && tre[1] != "Nessun file selezionato" && uno[1] != "Errore" && due[1] != "Errore" && tre[1] != "Errore")
                {
                    string sha256 = (SHA256.SHA256CheckSum(uno[1]));
                    MessageBox.Show(sha256);
                    bool check256 = SHA256.ControlloValori(sha256, due[1]);
                    MessageBox.Show(gpg.VerificaChiamataEsterna(due[1], tre[1], finger));
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
                    pbProgress.Value = 100;

                }
                else
                {
                    MessageBox.Show("ATTENZIONE! Inserire tutti i file richiesti.");

                }



                
            }




            string pagina = (string)lblIndice.Content;
           if(pagina == "1/3")
            {
                lblIndice.Content = "2/3";
                LblImporta.Text = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 33;
                BtnIndietro.IsEnabled = true;

           }
           if(pagina == "2/3")
            {
                lblIndice.Content = "3/3";
                LblImporta.Text = tre[0];
                lblFile.Content = tre[1];
                pbProgress.Value = 66;
                BtnAvanti.Content = "Esegui";
            }
           


        }


        public void PaginaPrima()
        {
            lblIndice.Content = "1/3";
            LblImporta.Text = uno[0];
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
                LblImporta.Text = due[0];
                lblFile.Content = due[1];
                pbProgress.Value = 33;
                BtnAvanti.Content = "Avanti";
            }
        }
    }
}
