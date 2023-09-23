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
    /// Логика взаимодействия для Huawei_Y8P.xaml
    /// </summary>
    public partial class Huawei_Y8P : Window
    {
        public Huawei_Y8P()
        {
            InitializeComponent();
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Huawei_Y8P huawei_Y8P = new Huawei_Y8P();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            text.Price1DataSet price1DataSet = ((text.Price1DataSet)(this.FindResource("price1DataSet")));
            // Загрузить данные в таблицу Huawei_Y8P. Можно изменить этот код как требуется.
            text.Price1DataSetTableAdapters.Huawei_Y8PTableAdapter price1DataSetHuawei_Y8PTableAdapter = new text.Price1DataSetTableAdapters.Huawei_Y8PTableAdapter();
            price1DataSetHuawei_Y8PTableAdapter.Fill(price1DataSet.Huawei_Y8P);
            System.Windows.Data.CollectionViewSource huawei_Y8PViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("huawei_Y8PViewSource")));
            huawei_Y8PViewSource.View.MoveCurrentToFirst();
            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу Huawei_Y8P. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.Huawei_Y8PTableAdapter price123456DataSetHuawei_Y8PTableAdapter = new text.Price123456DataSetTableAdapters.Huawei_Y8PTableAdapter();
            price123456DataSetHuawei_Y8PTableAdapter.Fill(price123456DataSet.Huawei_Y8P);
            System.Windows.Data.CollectionViewSource huawei_Y8PViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("huawei_Y8PViewSource1")));
            huawei_Y8PViewSource1.View.MoveCurrentToFirst();
        }
    }
}
