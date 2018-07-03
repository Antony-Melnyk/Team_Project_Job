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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string a;
        string b;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (Operations.SignIn(nickname: NickName_Text.Text, pass: Password_Text.Password) == true)
            {
                Close();
                MainJobWindow mw = new MainJobWindow();
                mw.NameBox.Text = NickName_Text.Text;
                mw.Show();
                Application.Current.Windows[0].Close();
            }
            else
                MessageBox.Show("Error. Check your login and password", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegWindow rw = new RegWindow();
            rw.ShowDialog();
        }
    }
}