using System;
using System.Windows;
using ClassLibrary1;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int[,] mass; // Поле для хранения массива
        private Class1 class1 = new Class1(); // Объект класса с методами

        public MainWindow()
        {
            InitializeComponent();
        }

        // Создание массива и его заполнение
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int mass_row = Convert.ToInt32(row.Text);
                int mass_col = Convert.ToInt32(col.Text);
                int mass_min = Convert.ToInt32(min.Text);
                int mass_max = Convert.ToInt32(max.Text);

                // Инициализация массива
                mass = new int[mass_row, mass_col];
                Random random = new Random();

                for (int i = 0; i < mass_row; i++)
                {
                    for (int j = 0; j < mass_col; j++)
                    {
                        mass[i, j] = random.Next(mass_min, mass_max + 1);
                    }
                }
                MessageBox.Show("Массив успешно создан и заполнен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Подсчёт суммы нечётных элементов
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (mass != null)
            {
                int sumOdd = class1.CulcOddNums(mass);
                result_odd.Text = sumOdd.ToString();
            }
            else
            {
                MessageBox.Show("Массив ещё не был создан!");
            }
        }

        // Подсчёт суммы всех элементов
        private void Button_Click_SumAll(object sender, RoutedEventArgs e)
        {
            if (mass != null)
            {
                int sumAll = class1.SumAllElements(mass);
                result_sum_all.Text = sumAll.ToString();
            }
            else
            {
                MessageBox.Show("Массив ещё не был создан!");
            }
        }

        // Подсчёт количества элементов больше среднего
        private void Button_Click_CountGreaterThanAvg(object sender, RoutedEventArgs e)
        {
            if (mass != null)
            {
                int countGreaterThanAvg = class1.CountElementsGreaterThanAverage(mass);
                result_greater_than_avg.Text = countGreaterThanAvg.ToString();
            }
            else
            {
                MessageBox.Show("Массив ещё не был создан!");
            }
        }
    }
}
