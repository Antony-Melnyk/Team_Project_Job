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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResumeForUser rfu = new ResumeForUser();
            rfu.ShowDialog();
            //ResumeWindow rw = new ResumeWindow();
            //rw.ShowDialog();
        }

        private void ls_Click(object sender, RoutedEventArgs e)
        {
            ChatWindow ch = new ChatWindow();
            ch.ShowDialog();
        }
    }
}
