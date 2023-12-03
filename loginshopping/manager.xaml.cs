using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for manager.xaml
    /// </summary>
    public partial class manager : Page
    {
        shoppingsEntities ss = new shoppingsEntities();
        public manager()
        {
            InitializeComponent();
            datagrid.ItemsSource = ss.Admin_.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin_ admin_ = new Admin_();
            admin_.name_ = txtname.Text;
            admin_.number = int.Parse(txtpass.Text);
            ss.Admin_.Add(admin_);
            ss.SaveChanges();
            datagrid.ItemsSource = ss.Admin_.ToList();
            MessageBox.Show("data saved succes");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var b = ss.Admin_.FirstOrDefault(x => x.name_ == txtname.Text);
            MessageBox.Show("Delete is succses");
            ss.Admin_.Remove(b);
            ss.SaveChanges();
            datagrid.ItemsSource = ss.Admin_.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Admin_ admin_= new Admin_();
            admin_.name_ = txtname.Text;
            admin_.number = int.Parse(txtpass.Text);
            ss.Admin_.AddOrUpdate(admin_);
            ss.SaveChanges();
            datagrid.ItemsSource = ss.Admin_.ToList();
            MessageBox.Show("data saved succes");
        }
    }
}
