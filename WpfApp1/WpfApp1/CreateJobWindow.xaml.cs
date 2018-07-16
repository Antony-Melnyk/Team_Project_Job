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
using DAL.Abstract;
using DAL.Concrete;
using BLL.Abstract;
using BLL.Concrete;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CreateJobWindow.xaml
    /// </summary>
    public partial class CreateJobWindow : Window
    {
        public IDal dal;
        public CreateJobWindow()
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

        private void CreateJobButton_Click(object sender, RoutedEventArgs e)
        {
            Operations o = new Operations(dal);
            using (DAL.Model1 m = new DAL.Model1())
            {
                o.AddJob(textBoxName.Text, "topik", m.Types.Where(x => x.Name == "Уборщица").FirstOrDefault(),
                Convert.ToInt32(textBoxSalary.Text), textBoxinfo.Text, "asdasd", m.Users.Where(x => x.Name == "antony").FirstOrDefault(), m.Cityes.Where(x => x.Name == "Киев").FirstOrDefault(), "a", "b");
            }

        }
    }
}