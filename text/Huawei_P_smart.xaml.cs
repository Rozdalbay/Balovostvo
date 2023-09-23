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
    /// Логика взаимодействия для Huawei_P_smart.xaml
    /// </summary>
    public partial class Huawei_P_smart : Window
    {
        public Huawei_P_smart()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Huawei_P_smart huawei_P_Smart = new Huawei_P_smart();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу Huawei_P_smart. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.Huawei_P_smartTableAdapter price123456DataSetHuawei_P_smartTableAdapter = new text.Price123456DataSetTableAdapters.Huawei_P_smartTableAdapter();
            price123456DataSetHuawei_P_smartTableAdapter.Fill(price123456DataSet.Huawei_P_smart);
            System.Windows.Data.CollectionViewSource huawei_P_smartViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("huawei_P_smartViewSource")));
            huawei_P_smartViewSource.View.MoveCurrentToFirst();
        }
    }
}
