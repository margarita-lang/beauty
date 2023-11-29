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

namespace beauty_studio.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddEditService.xaml
    /// </summary>
    public partial class WindowAddEditService : Window
    {
        public WindowAddEditService(Service service)
        {
            InitializeComponent();
            service.Title = tbName.Text;
            service.Description = tbDescription.Text;
            service.Cost = int.Parse(tbCost.Text);
            service.DurationInSeconds = int.Parse(tbDuration.Text);
            service.Discount = tbDiscount.Text;
            service.MainImagePath = tbManeImage.Text;
        }
        Service service;
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            tbName.Text = service.Title; 
            tbDescription.Text = service.Description;
            tbManeImage.Text = service.MainImagePath;
            tbDuration.Text = service.DurationInSeconds.ToString();
            tbCost.Text = service.Cost.ToString();
            tbDiscount.Text = service.Discount.ToString();
            if (service.ID == 0)
                App.beauty_Studio.SaveChanges();
            Close();
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
