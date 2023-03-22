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

namespace Shell.Res.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        public MainWin()
        {
            InitializeComponent();
            mFrame.Navigate(new Res.Pages.Clients());
        }

        private void lbPages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lbPages.SelectedIndex == 0)
            {
                mFrame.Navigate(new Res.Pages.Clients());
            }else if(lbPages.SelectedIndex == 1)
            {
                mFrame.Navigate(new Res.Pages.Orders());
            }else if (lbPages.SelectedIndex == 2)
            {
                mFrame.Navigate(new Res.Pages.Services());
            }
        }
    }
}
