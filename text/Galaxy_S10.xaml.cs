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
    /// Логика взаимодействия для Galaxy_S10.xaml
    /// </summary>
    public partial class Galaxy_S10 : Window
    {
        public Galaxy_S10()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Galaxy_S10 galaxy_S10 = new Galaxy_S10();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            text.Price1DataSet price1DataSet = ((text.Price1DataSet)(this.FindResource("price1DataSet")));
            // Загрузить данные в таблицу Galaxy_S10. Можно изменить этот код как требуется.
            text.Price1DataSetTableAdapters.Galaxy_S10TableAdapter price1DataSetGalaxy_S10TableAdapter = new text.Price1DataSetTableAdapters.Galaxy_S10TableAdapter();
            price1DataSetGalaxy_S10TableAdapter.Fill(price1DataSet.Galaxy_S10);
            System.Windows.Data.CollectionViewSource galaxy_S10ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("galaxy_S10ViewSource")));
            galaxy_S10ViewSource.View.MoveCurrentToFirst();
            text.Price123456DataSet price123456DataSet = ((text.Price123456DataSet)(this.FindResource("price123456DataSet")));
            // Загрузить данные в таблицу Galaxy_S10_Plus. Можно изменить этот код как требуется.
            text.Price123456DataSetTableAdapters.Galaxy_S10_PlusTableAdapter price123456DataSetGalaxy_S10_PlusTableAdapter = new text.Price123456DataSetTableAdapters.Galaxy_S10_PlusTableAdapter();
            price123456DataSetGalaxy_S10_PlusTableAdapter.Fill(price123456DataSet.Galaxy_S10_Plus);
            System.Windows.Data.CollectionViewSource galaxy_S10_PlusViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("galaxy_S10_PlusViewSource")));
            galaxy_S10_PlusViewSource.View.MoveCurrentToFirst();
        }
    }
}
