using System.Windows;
using System.Text.RegularExpressions;

namespace PracticalWork_11
{
    public partial class MainWindow : Window
    {
        private void FirstPart_Click(object sender, RoutedEventArgs e)
        {
            firstPartOut.Items.Clear();
            int i = 0;
            Regex[] regexCollection = new Regex[3];

            Regex firstRegex = new Regex("ahb");
            Regex secondRegex = new Regex("acb");
            Regex thirdRegex = new Regex("aeb");

            regexCollection[0] = firstRegex;
            regexCollection[1] = secondRegex;
            regexCollection[2] = thirdRegex;

            string lineWork = "ahb acb aeb aeeb adcb axeb";

            string[] dsdfsdf = new string[3];
            int[] index = new int[3];
            do
            {
                Match match = regexCollection[i].Match(lineWork);
                MatchCollection matches = regexCollection[i].Matches(lineWork);
                object[] mas = new object[matches.Count];
                if (matches.Count > 0)
                {
                    matches.CopyTo(mas, 0);
                    dsdfsdf[i] = match.Value;
                    index[i] = match.Index;
                    for (int u = 0; u < matches.Count; u++)
                    {
                        firstPartOut.Items.Add(mas[u]);
                    }
                } else { dsdfsdf[i] = "не найдено"; index[i] = 0; }
                i++;

            } while (i < 3);
            MessageBox.Show($"{dsdfsdf[0]} индекс первого символа - {index[0]} ; {dsdfsdf[1]} индекс первого символа - {index[1]} ; {dsdfsdf[2]} индекс первого символа - {index[2]} " );
        }

        private void SecondPart_Click(object sender, RoutedEventArgs e)
        {
            secondPartOut.Items.Clear();
            Regex regex = new Regex("a([0-9]{0,})a") ;
            string lineWork = "aa a1a a22a a333a a4444a a55555a aba aca";
            MatchCollection matches = regex.Matches(lineWork);
            if (matches.Count > 0)
            {
                object[] mas = new object[matches.Count];
                matches.CopyTo(mas, 0);
                for (int u = 0; u < matches.Count; u++)
                {
                    secondPartOut.Items.Add(mas[u]);
                }
            }
            else { MessageBox.Show("Не найдено"); }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Самсаков Андрей Александрович ИСП-31\nПрактическая работа №11\nДана строка 'ahb acb aeb aeeb adcb axeb'. Напишите регулярное выражение, которое найдет строки ahb, acb, aeb. Дана строка 'aa a1a a22a a333a a4444a a55555a aba aca'.Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', а между ними любое количество цифр(в том числе и ноль цифр, то есть строка 'aa').", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
