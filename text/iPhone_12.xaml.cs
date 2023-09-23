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
    /// Логика взаимодействия для iPhone_12.xaml
    /// </summary>
    public partial class iPhone_12 : Window
    {
        public iPhone_12()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            iPhone_12 iphone_12 = new iPhone_12();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            text.Price1DataSet price1DataSet = ((text.Price1DataSet)(this.FindResource("price1DataSet")));
            text.Price1DataSetTableAdapters.iPhone_12TableAdapter price1DataSetiPhone_12TableAdapter = new text.Price1DataSetTableAdapters.iPhone_12TableAdapter();
            price1DataSetiPhone_12TableAdapter.Fill(price1DataSet.iPhone_12);
            System.Windows.Data.CollectionViewSource iPhone_12ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("iPhone_12ViewSource")));
            iPhone_12ViewSource.View.MoveCurrentToFirst();
            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу iPhone_12. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.iPhone_12TableAdapter price123456DataSetiPhone_12TableAdapter = new text.Price123456DataSetTableAdapters.iPhone_12TableAdapter();
            price123456DataSetiPhone_12TableAdapter.Fill(price123456DataSet.iPhone_12);
            System.Windows.Data.CollectionViewSource iPhone_12ViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("iPhone_12ViewSource1")));
            iPhone_12ViewSource1.View.MoveCurrentToFirst();
        }
    }
}
