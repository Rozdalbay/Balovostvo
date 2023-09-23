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

namespace text
{
    /// <summary>
    /// Логика взаимодействия для Huawei_P40.xaml
    /// </summary>
    public partial class Huawei_P40 : Window
    {
        public Huawei_P40()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Huawei_P40 huawei_P40 = new Huawei_P40();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу Huawei_P40. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.Huawei_P40TableAdapter price123456DataSetHuawei_P40TableAdapter = new text.Price123456DataSetTableAdapters.Huawei_P40TableAdapter();
            price123456DataSetHuawei_P40TableAdapter.Fill(price123456DataSet.Huawei_P40);
            System.Windows.Data.CollectionViewSource huawei_P40ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("huawei_P40ViewSource")));
            huawei_P40ViewSource.View.MoveCurrentToFirst();
        }
    }
}
