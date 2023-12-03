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

namespace loginshopping
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        shoppingsEntities dg = new shoppingsEntities();
        
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            create_account create = new create_account();
            this.NavigationService.Navigate(create);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int pass = int.Parse(txtpassword.Text);
            var b = dg.Userr_.FirstOrDefault(x => x.name_ == txtusername.Text && x.number_ == pass);
            if (b != null)
            {
                MessageBox.Show("login Succes");
                user user = new user();
                this.NavigationService.Navigate(user);
            }
            else
            {
                MessageBox.Show("no item");
            }
            int paa = int.Parse(txtpassword.Text);
            var n = dg.Admin_.FirstOrDefault(x => x.name_ == txtusername.Text && x.number == paa);
            if (n != null)
            {
                MessageBox.Show("login Succes");
                manager manager = new manager();
                this.NavigationService.Navigate(manager);
            }
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forget forget = new forget();
            this.NavigationService.Navigate(forget);
        }
    }
}
