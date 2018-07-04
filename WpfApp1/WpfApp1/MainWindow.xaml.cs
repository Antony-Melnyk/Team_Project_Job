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
            //using (Model1 mw = new Model1())
            //{
            //    User s1 = new User();
            //    s1.NickName = "ShinigamiNengen";
            //    s1.Name = "Roma";
            //    s1.SName = "Adreev";
            //    s1.TName = "Anatolyovich";
            //    s1.PhoneNumber = "09847537573";
            //    s1.Password = "123";
            //    s1.Age = 16;
            //    s1.City = "Rivne";
            //    s1.Email = "roma.andreev@gmail.com";
            //    s1.ImgPath = "string";
            //    s1.Resume = "test";
            //    mw.Users.Add(s1);
            //    mw.SaveChanges();
            //}

            //if (Operations.SignIn(nickname: NickName_Text.Text, pass: Password_Text.Password) == true)
            //{
            //    Close();
            //    MainJobWindow mw = new MainJobWindow();
            //    mw.NameBox.Text = NickName_Text.Text;
            //    mw.Show();
            //    Application.Current.Windows[0].Close();
            //}
            //else
            //    MessageBox.Show("Error. Check your login and password", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegWindow rw = new RegWindow();
            rw.ShowDialog();
        }
    }
}