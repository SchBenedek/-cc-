using System;
using System.Windows;

namespace öccá
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
            Feladatok f1 = new Feladatok();
            if(f1.beolvas())
            {
                MessageBox.Show("sikeres");
            }
            else
            {
                MessageBox.Show("Nem");
            }
            string a = "";
            for(int i = 0;i<f1.lista.Countó; i++)
            {
                a+= f1.lista[i]+"\n";
            }
            kiir.Content = a;
        }
    }
}
