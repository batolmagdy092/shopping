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
    /// Interaction logic for create_account.xaml
    /// </summary>
    public partial class create_account : Page
    {
        shoppingsEntities dd = new shoppingsEntities();
        public create_account()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (combo.SelectedIndex== 0)
            {
                Userr_ userr_ = new Userr_();
                userr_.name_ = txtuser.Text;
                userr_.number_=int.Parse( txtpass.Text);
                dd.Userr_.Add(userr_);
                dd.SaveChanges();
                user user = new user();
                this.NavigationService.Navigate(user);
            }
            if (combo.SelectedIndex== 1)
            {
                Admin_ admin_ = new Admin_();
                admin_.name_ = txtuser.Text;
                admin_.number=int.Parse( txtpass.Text);
                dd.Admin_.Add(admin_);
                dd.SaveChanges();
                manager manager = new manager();
                this.NavigationService.Navigate(manager);

            }
        }
    }
}
