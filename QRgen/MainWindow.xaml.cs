using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
using QRCoder;
using QRCoder.Xaml;

namespace QRgen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string zadanyText = TextboxInput.Text;
            
            //Vytvoření generátoru QR kódů
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();

            //Vytvoření dat QR kódu
            QRCodeData dataQRkodu = qRCodeGenerator.CreateQrCode(zadanyText, QRCodeGenerator.ECCLevel.M);

            //Vytvoření QR kódu s daty vytvořenými nahoře
            XamlQRCode qrKod = new XamlQRCode(dataQRkodu);


            DrawingImage QRimage = qrKod.GetGraphic(30);
            obrazekQR.Source = QRimage;
           
        }
    }
}
