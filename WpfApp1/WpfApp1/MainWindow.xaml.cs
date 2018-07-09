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
using BLL;
using BLL.Concrete;
using DAL;
using DAL.Concrete;
using DAL.Abstract;

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

        private void ButtonSignIn_Click(object sender, RoutedEventArgs e)
        {
            //Operations operations = new Operations(DAL.Abstract.IDal);

            //if (operations.SignIn(NickName_Text.Text, Password_Text.Password) == true)
            //{
                MainJobWindow mw = new MainJobWindow();
                mw.Show();
                mw.NameBox.Text = NickName_Text.Text;
                Close();
            //}
            //else
                MessageBox.Show("Error. Check your login and password", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegWindow rw = new RegWindow();
            rw.ShowDialog();
        }
    }
}