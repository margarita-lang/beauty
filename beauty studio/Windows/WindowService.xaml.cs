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
    /// Логика взаимодействия для WindowService.xaml
    /// </summary>
    public partial class WindowService : Window
    {
        public WindowService()
        {
            InitializeComponent();
            dgService.ItemsSource = App.beauty_Studio.Service.ToList();
        }
        private void btnAddService_Click(object sender, RoutedEventArgs e)
        {
            WindowAddEditService windowAdd = new WindowAddEditService();
            windowAdd.ShowDialog();
            dgService.ItemsSource = null;
            dgService.ItemsSource = App.beauty_Studio.Service.ToList();
        }

        private void btnEditService_Click(object sender, RoutedEventArgs e)
        {
            try 
            { 
                Service service = dgService.SelectedItem as Service;
                WindowAddEditService editService = new WindowAddEditService(service);
                editService.ShowDialog();
                dgService.ItemsSource = null;
                dgService.ItemsSource = App.beauty_Studio.Service.ToList();
            }catch { MessageBox.Show("Выберите запись для редактирования"); }
        }

        private void btnDeleteService_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service service = dgService.SelectedItem as Service;
                App.beauty_Studio.Service.Remove(service);
                App.beauty_Studio.SaveChanges();
                dgService.ItemsSource = null;
                dgService.ItemsSource = App.beauty_Studio.Service.ToList();
            }
            catch { MessageBox.Show("Выберите запись для удаления"); }
        }
    }
}
