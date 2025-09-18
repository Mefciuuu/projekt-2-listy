using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cwiczenie_2_formularze
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

        private void Wybierz_Click(object sender, RoutedEventArgs e)
        {
            if (listaOpcji.SelectedIndex == 0)
            {
                MessageBox.Show("Ja lubie uprawiac sport");
            }
            else if (listaOpcji.SelectedIndex == 1)
            {
                MessageBox.Show("Ja lubie muzyke");
            }
            else if (listaOpcji.SelectedIndex == 2)
            {
                MessageBox.Show("Lubie podroze");
            }
            else
            {
                MessageBox.Show("Nie wybrano opcji");
            }
        }
    }
}