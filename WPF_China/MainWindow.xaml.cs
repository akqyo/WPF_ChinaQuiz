using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number_of_correct_answers = 0;
        
        public MainWindow()
        {
            
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
                number_of_correct_answers++;  
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            number_of_correct_answers--;
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {

            if (number_of_correct_answers >= 5)
            {
                MessageBox.Show($"Вы отлично пройти тест на sosial reiting! Xi Jinping желать лично поговорить!!(Количество ваш правильный ответ = {number_of_correct_answers})");
            }
            else
            {
                MessageBox.Show($"Вы разочаровать китайский народный республика, -2517373 sosial reiting!!!(Количество ваш правильный ответ = {number_of_correct_answers})");
            }
        }
    }
}
