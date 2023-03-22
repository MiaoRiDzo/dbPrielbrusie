using Shell.Res.Advaned;
using Shell.Res.Windows;
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

namespace Shell
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class loginPage : Window
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            
            string login = tbLogin.Text;
            string pass = tbPass.Password;
            List<User> users = PrielbrusyeEntities.getContext().User.ToList();
            User user = null;
            //Поиск пользователя по login
            foreach (User userDB in users)
            {
                if(userDB.Login == login) { user = userDB; break; } else { MessageBox.Show("Пользователь не найлен;"); }
            }
            //Проверка пароля
            if(user != null)
            {
                if (user.Passsword == pass) {
                    MainWin mainWin = new MainWin();
                    mainWin.Show();
                    this.Close();
                }else { MessageBox.Show("Невеный пароль;"); }
            }
        }
    }
}
