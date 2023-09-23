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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace text
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string connection = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Учителя\Desktop\Новая папка (5)\Новая папка (3)\Диплом\Base\Price123456.accdb";
        public OleDbDataReader Select(string selectSQL)
        {
            OleDbConnection connect = new OleDbConnection(connection);
            connect.Open();
            OleDbCommand cmd = new OleDbCommand(selectSQL, connect);
            OleDbDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public void telefon_Click(object sender, RoutedEventArgs e)
        {
            models_button.Visibility = Visibility.Visible;
            models_button2.Visibility = Visibility.Visible;
            models_button3.Visibility = Visibility.Visible;
        }

        private void models_button_Click(object sender, RoutedEventArgs e)
        {
            models_button.Visibility = Visibility.Hidden;
            models_button2.Visibility = Visibility.Hidden;
            models_button3.Visibility = Visibility.Hidden;
            Podmodels_button.Visibility = Visibility.Visible;
            Podmodels_button2.Visibility = Visibility.Visible;
            Podmodels_button3.Visibility = Visibility.Visible;
            Return.Visibility = Visibility.Visible;
        }
        private void models_button2_Click(object sender, RoutedEventArgs e)
        {
            models_button.Visibility = Visibility.Hidden;
            models_button2.Visibility = Visibility.Hidden;
            models_button3.Visibility = Visibility.Hidden;
            Podmodels2_button.Visibility = Visibility.Visible;
            Podmodels2_button2.Visibility = Visibility.Visible;
            Podmodels2_button3.Visibility = Visibility.Visible;
            Return2.Visibility = Visibility.Visible;
        }
        private void models_button3_Click(object sender, RoutedEventArgs e)
        {
            models_button.Visibility = Visibility.Hidden;
            models_button2.Visibility = Visibility.Hidden;
            models_button3.Visibility = Visibility.Hidden;
            Podmodels3_button.Visibility = Visibility.Visible;
            Podmodels3_button2.Visibility = Visibility.Visible;
            Podmodels3_button3.Visibility = Visibility.Visible;
            Return3.Visibility = Visibility.Visible;
        }

        //назад
            private void Return_Click(object sender, RoutedEventArgs e)
            {
                models_button.Visibility = Visibility.Visible;
                models_button2.Visibility = Visibility.Visible;
                models_button3.Visibility = Visibility.Visible;
                Podmodels_button.Visibility = Visibility.Hidden;
                Podmodels_button2.Visibility = Visibility.Hidden;
                Podmodels_button3.Visibility = Visibility.Hidden;
                Return.Visibility = Visibility.Hidden;
            }
            private void Return2_Click(object sender, RoutedEventArgs e)
            {
                models_button.Visibility = Visibility.Visible;
                models_button2.Visibility = Visibility.Visible;
                models_button3.Visibility = Visibility.Visible;
                Podmodels2_button.Visibility = Visibility.Hidden;
                Podmodels2_button2.Visibility = Visibility.Hidden;
                Podmodels2_button3.Visibility = Visibility.Hidden;
                Return2.Visibility = Visibility.Hidden;
            }
            private void Return3_Click(object sender, RoutedEventArgs e)
            {
                models_button.Visibility = Visibility.Visible;
                models_button2.Visibility = Visibility.Visible;
                models_button3.Visibility = Visibility.Visible;
                Podmodels3_button.Visibility = Visibility.Hidden;
                Podmodels3_button2.Visibility = Visibility.Hidden;
                Podmodels3_button3.Visibility = Visibility.Hidden;
                Return3.Visibility = Visibility.Hidden;
            }

        //samsung
            private void Podmodels_button_Click(object sender, RoutedEventArgs e)
            {
                Galaxy_S10 galaxy_S10 = new Galaxy_S10();
                galaxy_S10.Show();
                MainWindow mainWindow = new MainWindow();
                this.Close();
            }

            private void Podmodels_button2_Click(object sender, RoutedEventArgs e)
            {
                Galaxy_S20 galaxy_S20 = new Galaxy_S20();
                galaxy_S20.Show();
                MainWindow mainWindow = new MainWindow();
                this.Close();
            }

            private void Podmodels_button3_Click(object sender, RoutedEventArgs e)
            {
                Galaxy_S21 galaxy_S21 = new Galaxy_S21();
                galaxy_S21.Show();
                MainWindow mainWindow = new MainWindow();
                this.Close();
            }

        //iphone
            private void Podmodels2_button_Click(object sender, RoutedEventArgs e)
            {
                iPhone_XR iphone_XR = new iPhone_XR();
                iphone_XR.Show();
                MainWindow mainWindow = new MainWindow();
            
            Application.Current.ShutdownMode = ShutdownMode.OnLastWindowClose;
            this.Close();
        }

           private void Podmodels2_button2_Click(object sender, RoutedEventArgs e)
            {
                 this.Hide();
                iPhone_11 iphone_11 = new iPhone_11();
                iphone_11.Show();
            }

            private void Podmodels2_button3_Click(object sender, RoutedEventArgs e)
            {
                iPhone_12 iphone_12 = new iPhone_12();
                iphone_12.Show();
                MainWindow mainWindow = new MainWindow();
                this.Close();
            }

        //Huawei
            private void Podmodels3_button_Click(object sender, RoutedEventArgs e)
            {
                Huawei_P40 huawei_P40 = new Huawei_P40();
                huawei_P40.Show();
                MainWindow mainWindow = new MainWindow();
                this.Close();
            }

            private void Podmodels3_button2_Click(object sender, RoutedEventArgs e)
            {
                Huawei_P_smart huawei_P_Smart = new Huawei_P_smart();
                huawei_P_Smart.Show();
                MainWindow mainWindow = new MainWindow();
                this.Close();
            }

            private void Podmodels3_button3_Click(object sender, RoutedEventArgs e)
            {
                Huawei_Y8P huawei_Y8P = new Huawei_Y8P();
                huawei_Y8P.Show();
                MainWindow mainWindow = new MainWindow();
                this.Close();
            }

    }
}
