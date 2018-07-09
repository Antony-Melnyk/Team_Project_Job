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
using BLL.Abstract;
using DAL.Abstract;
using BLL.Concrete;
using DAL.Concrete;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainJobWindow.xaml
    /// </summary>
    public partial class MainJobWindow : Window
    {
        public MainJobWindow()
        {
            InitializeComponent();

            using (DAL.Model1 m = new DAL.Model1())
            {
                foreach (City c in m.Cityes.ToList())
                {
                    comboBoxCityes.Items.Add(c.Name);
                }
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
        }

        private void Hyperlink_Click_Resume(object sender, RoutedEventArgs e)
        {
            ResumeWindow rw = new ResumeWindow();
            rw.ShowDialog();
        }

        private void Hyperlink_Click_Profile(object sender, RoutedEventArgs e)
        {
            Profile p = new Profile();
            p.ShowDialog();
        }
    }
}