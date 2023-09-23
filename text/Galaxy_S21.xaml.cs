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
    /// Логика взаимодействия для Galaxy_S21.xaml
    /// </summary>
    public partial class Galaxy_S21 : Window
    {
        public Galaxy_S21()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Galaxy_S21 galaxy_S21 = new Galaxy_S21();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу Galaxy_S21. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.Galaxy_S21TableAdapter price123456DataSetGalaxy_S21TableAdapter = new text.Price123456DataSetTableAdapters.Galaxy_S21TableAdapter();
            price123456DataSetGalaxy_S21TableAdapter.Fill(price123456DataSet.Galaxy_S21);
            System.Windows.Data.CollectionViewSource galaxy_S21ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("galaxy_S21ViewSource")));
            galaxy_S21ViewSource.View.MoveCurrentToFirst();
        }
    }
}
