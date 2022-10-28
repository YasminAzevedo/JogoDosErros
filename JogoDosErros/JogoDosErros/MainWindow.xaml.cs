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

namespace JogoDosErros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool verifica = false;
        bool erro1 = false;
        bool erro2 = false;
        bool erro3 = false;
        bool erro4 = false;
        bool erro5 = false;
        bool erro6 = false;
        bool erro7 = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        
    
        private void erro1_Click(object sender, RoutedEventArgs e)
        {
            imgAcerto1.Visibility = Visibility.Visible;
            erro1 = true;
            ganhou();
            reiniciar();
        }
        private void erro2_Click(object sender, RoutedEventArgs e)
        {
            imgAcerto2.Visibility = Visibility.Visible;
            erro2 = true;
            ganhou();
            reiniciar();
        }
        private void erro3_Click(object sender, RoutedEventArgs e)
        {
            imgAcerto3.Visibility = Visibility.Visible;
            erro3 = true;
            ganhou();
            reiniciar();
        }
        private void erro4_Click(object sender, RoutedEventArgs e)
        {
            imgAcerto4.Visibility = Visibility.Visible;
            erro4 = true;
            ganhou();
            reiniciar();
        }
        private void erro5_Click(object sender, RoutedEventArgs e)
        {
            imgAcerto5.Visibility = Visibility.Visible;
            erro5 = true;
            ganhou();
            reiniciar();
        }
        private void erro6_Click(object sender, RoutedEventArgs e)
        {
            imgAcerto6.Visibility = Visibility.Visible;
            erro6 = true;
            ganhou();
            reiniciar();
        }
        private void erro7_Click(object sender, RoutedEventArgs e)
        {
            imgAcerto7.Visibility = Visibility.Visible;
            erro7 = true;
            ganhou();
            reiniciar();
        }
        private void ganhou()
        {
            if (erro1 == true && erro2 == true && erro3 == true && erro4 == true && erro5 == true && erro6 == true && erro7 == true)
            {
                MessageBoxResult result = MessageBox.Show(
                    "Todos os erros foram encontrados.",
                    "Parabéns!",
                    MessageBoxButton.OK
                    );
                verifica = true;


            }
        }
        private void reiniciar ()
        {
            if (verifica == true)
            {
                verifica = false;
                erro1 = false;
                erro2 = false;
                erro3 = false;
                erro4 = false;
                erro5 = false;
                erro6 = false;
                erro7 = false;
                imgAcerto1.Visibility = Visibility.Hidden;
                imgAcerto2.Visibility = Visibility.Hidden;
                imgAcerto3.Visibility = Visibility.Hidden;
                imgAcerto4.Visibility = Visibility.Hidden;
                imgAcerto5.Visibility = Visibility.Hidden;
                imgAcerto6.Visibility = Visibility.Hidden;
                imgAcerto7.Visibility = Visibility.Hidden;

            }
        }

    }
}
