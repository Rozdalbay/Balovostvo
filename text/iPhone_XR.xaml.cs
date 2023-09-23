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
using System.Data.OleDb;

namespace text
{
    /// <summary>
    /// Логика взаимодействия для iPhone_XR.xaml
    /// </summary>
    public partial class iPhone_XR : Window
    {
        public iPhone_XR()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            iPhone_XR iphone_XR = new iPhone_XR();
            this.Close();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу iPhone_XR. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.iPhone_XRTableAdapter price123456DataSetiPhone_XRTableAdapter = new text.Price123456DataSetTableAdapters.iPhone_XRTableAdapter();
            price123456DataSetiPhone_XRTableAdapter.Fill(price123456DataSet.iPhone_XR);
            System.Windows.Data.CollectionViewSource iPhone_XRViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("iPhone_XRViewSource1")));
            iPhone_XRViewSource1.View.MoveCurrentToFirst();
        }
    }
}
