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

namespace practice_8
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

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-34, Горшков Илья, Вариант 2. Создать интерфейсы - корабль, грузовой транспорт. Создать класс грузовой" +
                 "корабль.Класс должен включать конструктор, функцию для формирования строки" +
                            "информации о работнике.Сравнение производить по грузоподъемности.");
        }

        private void shipDescription(object sender, RoutedEventArgs e)
        {
            CargoShip ship = new CargoShip(int.Parse(load1.Text), int.Parse(date1.Text), model1.Text);
            MessageBox.Show($"{ship.ShipDescription()}", "О судне №1.", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void compareships(object sender, RoutedEventArgs e)
        {
            CargoShip ship1 = new CargoShip(int.Parse(load1.Text), int.Parse(date1.Text), model1.Text);
            CargoShip ship2 = new CargoShip(int.Parse(load2.Text), int.Parse(date2.Text), model2.Text);
            int result = ship1.CompareTo(ship2);
            if (result == 0)
            {
                MessageBox.Show("Грузоподъемность судов одинакова!", "Сравнение грузоподъемности", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (result < 0)
            {
                MessageBox.Show("Грузоподъемность первого судна меньше грузоподъемности второго!", "Сравнение грузопоъемности", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (result > 0)
            {
                MessageBox.Show("Грузоподъемность первого судна больше грузоподъемности второго!", "Сравнение грузопоъемности", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
