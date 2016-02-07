using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Elsword_Secrets
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

        private void Peito_imgHamelGrendizado_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Faltam alguns itens!", "Alerta", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Calca_imgHamelGrendizado_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Faltam alguns itens!", "Alerta", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Luva_imgHamelGrendizado_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Faltam alguns itens!", "Alerta", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Sapato_imgHamelGrendizado_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Faltam alguns itens!", "Alerta", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
