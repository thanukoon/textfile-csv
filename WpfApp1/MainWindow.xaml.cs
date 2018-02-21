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
using System.IO;
using System.Xml.Linq;


namespace WpfApp1
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

        private void Butt(object sender, RoutedEventArgs e)
        {
            Button n = (Button)sender;

            using (TextWriter sw = new StreamWriter("E:\\files.csv"))
            {
                string strData = "1";
                float floatData = 324.563F;//Note it's a float not string
                sw.WriteLine("{0},{1}", strData, floatData.ToString("F2"));
            }
            this.Close();
        }

        private void Butt1(object sender, RoutedEventArgs e)
        {
           

            using (TextWriter sw = new StreamWriter("E:\\files.csv"))
            {
                int strData = 0;
                float floatData = 324.563F;//Note it's a float not string
                sw.WriteLine("{0},{1}", strData, floatData.ToString("F2"));
                
               

            }
            //this.Close();
            using (StreamReader sr = new StreamReader("E:\\files1.csv"))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);

                Console.ReadLine();
            }
        }
       

    }

    

   

       
}

