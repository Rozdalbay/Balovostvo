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
    /// Логика взаимодействия для iPhone_11.xaml
    /// </summary>
    public partial class iPhone_11 : Window
    {
        public iPhone_11()
        {
            InitializeComponent();
        }

        /*private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            iPhone_11 iphone_11 = new iPhone_11();
            this.Close();
            
        }*/
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            text.Price1DataSet price1DataSet = ((text.Price1DataSet)(this.FindResource("price1DataSet")));
            // Загрузить данные в таблицу iPhone_11. Можно изменить этот код как требуется.
            text.Price1DataSetTableAdapters.iPhone_11TableAdapter price1DataSetiPhone_11TableAdapter = new text.Price1DataSetTableAdapters.iPhone_11TableAdapter();
            price1DataSetiPhone_11TableAdapter.Fill(price1DataSet.iPhone_11);
            System.Windows.Data.CollectionViewSource iPhone_11ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("iPhone_11ViewSource")));
            iPhone_11ViewSource.View.MoveCurrentToFirst();
            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу iPhone_11. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.iPhone_11TableAdapter price123456DataSetiPhone_11TableAdapter = new text.Price123456DataSetTableAdapters.iPhone_11TableAdapter();
            price123456DataSetiPhone_11TableAdapter.Fill(price123456DataSet.iPhone_11);
            System.Windows.Data.CollectionViewSource iPhone_11ViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("iPhone_11ViewSource1")));
            iPhone_11ViewSource1.View.MoveCurrentToFirst();
        }
    }
}
