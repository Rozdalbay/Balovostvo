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
    /// Логика взаимодействия для Galaxy_S20.xaml
    /// </summary>
    public partial class Galaxy_S20 : Window
    {
        public Galaxy_S20()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Galaxy_S20 galaxy_S20 = new Galaxy_S20();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу Galaxy_S20_Plus. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.Galaxy_S20_PlusTableAdapter price123456DataSetGalaxy_S20_PlusTableAdapter = new text.Price123456DataSetTableAdapters.Galaxy_S20_PlusTableAdapter();
            price123456DataSetGalaxy_S20_PlusTableAdapter.Fill(price123456DataSet.Galaxy_S20_Plus);
            System.Windows.Data.CollectionViewSource galaxy_S20_PlusViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("galaxy_S20_PlusViewSource")));
            galaxy_S20_PlusViewSource.View.MoveCurrentToFirst();
        }
    }
}
