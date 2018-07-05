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
            using (Model1 mw = new Model1())
            {
                User s1 = new User();
                s1.NickName = "ShinigamiNengen";
                s1.Name = "Roma";
                s1.SName = "Adreev";
                s1.TName = "Anatolyovich";
                s1.PhoneNumber = "09847537573";
                s1.Password = "123";
                s1.Age = 16;
                s1.CityId = 24;
                s1.Email = "roma.andreev@gmail.com";
                s1.ImgPath = "string";
                s1.Resume = "test";
                mw.Users.Add(s1);
                mw.SaveChanges();
            }

            using (Model1 mw = new Model1())
            {
                DAL.Concrete.Type t1 = new DAL.Concrete.Type();
                DAL.Concrete.Type t2 = new DAL.Concrete.Type();
                DAL.Concrete.Type t3 = new DAL.Concrete.Type();
                DAL.Concrete.Type t4 = new DAL.Concrete.Type();
                DAL.Concrete.Type t5 = new DAL.Concrete.Type();
                DAL.Concrete.Type t6 = new DAL.Concrete.Type();
                DAL.Concrete.Type t7 = new DAL.Concrete.Type();
                DAL.Concrete.Type t8 = new DAL.Concrete.Type();
                DAL.Concrete.Type t9 = new DAL.Concrete.Type();
                DAL.Concrete.Type t10 = new DAL.Concrete.Type();
                DAL.Concrete.Type t11 = new DAL.Concrete.Type();
                DAL.Concrete.Type t12 = new DAL.Concrete.Type();
                DAL.Concrete.Type t13 = new DAL.Concrete.Type();
                DAL.Concrete.Type t14= new DAL.Concrete.Type();
                DAL.Concrete.Type t15 = new DAL.Concrete.Type();
                DAL.Concrete.Type t16 = new DAL.Concrete.Type();
                DAL.Concrete.Type t17 = new DAL.Concrete.Type();
                DAL.Concrete.Type t18 = new DAL.Concrete.Type();
                DAL.Concrete.Type t19 = new DAL.Concrete.Type();
                DAL.Concrete.Type t20 = new DAL.Concrete.Type();
                DAL.Concrete.Type t21 = new DAL.Concrete.Type();
                DAL.Concrete.Type t22 = new DAL.Concrete.Type();
                DAL.Concrete.Type t23 = new DAL.Concrete.Type();
                DAL.Concrete.Type t24 = new DAL.Concrete.Type();
                DAL.Concrete.Type t25 = new DAL.Concrete.Type();
                DAL.Concrete.Type t26 = new DAL.Concrete.Type();
                DAL.Concrete.Type t27 = new DAL.Concrete.Type();
                DAL.Concrete.Type t28 = new DAL.Concrete.Type();
                DAL.Concrete.Type t29 = new DAL.Concrete.Type();
                DAL.Concrete.Type t30 = new DAL.Concrete.Type();
                DAL.Concrete.Type t31 = new DAL.Concrete.Type();
                DAL.Concrete.Type t32 = new DAL.Concrete.Type();
                DAL.Concrete.Type t33 = new DAL.Concrete.Type();
                DAL.Concrete.Type t34 = new DAL.Concrete.Type();
                DAL.Concrete.Type t35 = new DAL.Concrete.Type();
                DAL.Concrete.Type t36 = new DAL.Concrete.Type();
                DAL.Concrete.Type t37 = new DAL.Concrete.Type();
                DAL.Concrete.Type t38 = new DAL.Concrete.Type();
                DAL.Concrete.Type t39 = new DAL.Concrete.Type();
                DAL.Concrete.Type t40 = new DAL.Concrete.Type();
                DAL.Concrete.Type t41 = new DAL.Concrete.Type();
                DAL.Concrete.Type t42 = new DAL.Concrete.Type();
                DAL.Concrete.Type t43 = new DAL.Concrete.Type();
                DAL.Concrete.Type t44 = new DAL.Concrete.Type();
                DAL.Concrete.Type t45 = new DAL.Concrete.Type();
                DAL.Concrete.Type t46 = new DAL.Concrete.Type();
                DAL.Concrete.Type t47 = new DAL.Concrete.Type();
                DAL.Concrete.Type t48 = new DAL.Concrete.Type();
                DAL.Concrete.Type t49 = new DAL.Concrete.Type();

                t1.Name = "Автоэлектрик";
                t2.Name = "Адвокат";
                t3.Name = "Административный директор";
                t4.Name = "Администратор офиса";
                t5.Name = "Бармен";
                t6.Name = "Библиотекарь";
                t7.Name = "Бариста";
                t8.Name = "Бренд-менеджер";
                t9.Name = "Брокер";
                t10.Name = "Бухгалтер";
                t11.Name = "Водитель";
                t12.Name = "Грузчик";
                t13.Name = "Графический дизайнер";
                t14.Name = "Дворник";
                t15.Name = "Домработница";
                t16.Name = "Директор";
                t17.Name = "Журналист";
                t18.Name = "Заведующий складом";
                t19.Name = "Инженер-механик";
                t20.Name = "Интернет-маркетолог";
                t21.Name = "Кредитный эксперт";
                t22.Name = "Кассир";
                t23.Name = "Кузнец";
                t24.Name = "Лаборант";
                t25.Name = "Маркетолог-аналитик";
                t26.Name = "Маркетолог";
                t27.Name = "Менеджер по продажам";
                t28.Name = "Наладчик";
                t29.Name = "Озеленитель";
                t30.Name = "Офис-менеджер";
                t31.Name = "Парикмахер";
                t32.Name = "Продавец";
                t33.Name = "Программист SQL";
                t34.Name = "Руководитель магазина";
                t35.Name = "Специалист по технической поддержке";
                t36.Name = "Секретарь на ресепшен";
                t37.Name = "Специалист по работе с персоналом";
                t38.Name = "Телефонный оператор";
                t39.Name = "Телохранитель";
                t40.Name = "Уборщица";
                t41.Name = "Фандрайзер";
                t42.Name = "Фармацевт";
                t43.Name = "Цветокорректор";
                t44.Name = "Штукатур";
                t45.Name = "Электромеханик";
                t46.Name = "Ювелир";
                t47.Name = "Юрист";
                t48.Name = "BTL-менеджер";
                t49.Name = "C# программист";

                mw.Types.Add(t1);
                mw.Types.Add(t2);
                mw.Types.Add(t3);
                mw.Types.Add(t4);
                mw.Types.Add(t5);
                mw.Types.Add(t6);
                mw.Types.Add(t7);
                mw.Types.Add(t8);
                mw.Types.Add(t9);
                mw.Types.Add(t10);
                mw.Types.Add(t11);
                mw.Types.Add(t12);
                mw.Types.Add(t13);
                mw.Types.Add(t14);
                mw.Types.Add(t15);
                mw.Types.Add(t16);
                mw.Types.Add(t17);
                mw.Types.Add(t18);
                mw.Types.Add(t19);
                mw.Types.Add(t20);
                mw.Types.Add(t21);
                mw.Types.Add(t22);
                mw.Types.Add(t23);
                mw.Types.Add(t24);
                mw.Types.Add(t25);
                mw.Types.Add(t26);
                mw.Types.Add(t27);
                mw.Types.Add(t28);
                mw.Types.Add(t29);
                mw.Types.Add(t30);
                mw.Types.Add(t31);
                mw.Types.Add(t32);
                mw.Types.Add(t33);
                mw.Types.Add(t34);
                mw.Types.Add(t35);
                mw.Types.Add(t36);
                mw.Types.Add(t37);
                mw.Types.Add(t38);
                mw.Types.Add(t39);
                mw.Types.Add(t40);
                mw.Types.Add(t41);
                mw.Types.Add(t42);
                mw.Types.Add(t43);
                mw.Types.Add(t44);
                mw.Types.Add(t45);
                mw.Types.Add(t46);
                mw.Types.Add(t47);
                mw.Types.Add(t48);
                mw.Types.Add(t49);
                mw.SaveChanges();


            }
            using (Model1 mw = new Model1())
            {
                User s1 = new User();
                s1.NickName = "ShinigamiNengen";
                s1.Name = "Roma";
                s1.SName = "Adreev";
                s1.TName = "Anatolyovich";
                s1.PhoneNumber = "09847537573";
                s1.Password = "123";
                s1.Age = 16;
                s1.City = "Rivne";
                s1.Email = "roma.andreev@gmail.com";
                s1.ImgPath = "string";
                s1.Resume = "test";
                mw.Users.Add(s1);
                mw.SaveChanges();
            }

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