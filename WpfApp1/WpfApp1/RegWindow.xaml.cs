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
using BLL;
using BLL.Concrete;
using DAL;
using DAL.Concrete;
using DAL.Abstract;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public IDal dal;
        public RegWindow()
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

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            Operations op = new Operations(dal);

            if(op.Registration(textBoxFName.Text,textBoxSName.Text,textBoxThirdName.Text,textBoxNickname.Text,textBoxPassword.Password,textBoxPhoneNumber.Text,
                comboBoxCityes.SelectedIndex,Convert.ToInt16(textBoxAge.Text),textBoxEmail.Text)==true)
            {
                MessageBox.Show("Registration succesfull");
            }
            else
            {
            MessageBox.Show("Error. Check your login and password", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            //IDal dal;
            //Operations operations = new Operations(dal: dal);

            //if (operations.Registration(textBoxFName.Text, textBoxSName.Text, textBoxThirdName.Text,
            //    textBoxNickname.Text, textBoxPassword.Password, Convert.ToInt32(textBoxAge.Text), textBoxEmail.Text) == true)
            //{
            //    MainJobWindow mw = new MainJobWindow();
            //    mw.Show();
            //    mw.NameBox.Text = textBoxNickname.Text;
            //    Close();
            //}
            //else
            //    MessageBox.Show("Error. Check your login and password", "Message", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
