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

namespace Scrambler
{
    /// <summary>
    /// Логика взаимодействия для Diagrams.xaml
    /// </summary>
    public partial class Diagrams : Window
    {
        public Diagrams(int firstHeight, int editHeight)
        {
            InitializeComponent();

            Rectangle firstRect = new Rectangle();
            firstRect.Width = 110;
            firstRect.Height = firstHeight + 30;
            firstRect.Stroke = Brushes.Blue;
            firstRect.Fill = Brushes.Blue;
            firstRect.StrokeThickness = 2;
            firstRect.HorizontalAlignment = HorizontalAlignment.Left;
            firstRect.VerticalAlignment = VerticalAlignment.Bottom;
            grid.Children.Add(firstRect);

            TextBlock firstTxtBlck = new TextBlock();
            firstTxtBlck.Text = "Исходная";
            firstTxtBlck.HorizontalAlignment = HorizontalAlignment.Left;
            firstTxtBlck.VerticalAlignment = VerticalAlignment.Bottom;
            firstTxtBlck.Foreground = Brushes.White;
            firstTxtBlck.FontSize = 14;
            firstTxtBlck.Margin = new Thickness(25, 0, 0, 0);
            grid.Children.Add(firstTxtBlck);

            TextBlock firstTxtBlckNum = new TextBlock();
            firstTxtBlckNum.Text = firstHeight.ToString();
            firstTxtBlckNum.HorizontalAlignment = HorizontalAlignment.Left;
            firstTxtBlckNum.VerticalAlignment = VerticalAlignment.Bottom;
            firstTxtBlckNum.Foreground = Brushes.White;
            firstTxtBlckNum.FontSize = 18;
            firstTxtBlckNum.Margin = new Thickness(50, 0, 0, 30);
            grid.Children.Add(firstTxtBlckNum);

            Rectangle editRect = new Rectangle();
            editRect.Width = 110;
            editRect.Height = editHeight + 30;
            editRect.Fill = Brushes.Red;
            editRect.Stroke = Brushes.Red;
            firstRect.StrokeThickness = 2;
            editRect.HorizontalAlignment = HorizontalAlignment.Right;
            editRect.VerticalAlignment = VerticalAlignment.Bottom;
            grid.Children.Add(editRect);

            TextBlock editTxtBlck = new TextBlock();
            editTxtBlck.Text = "Обработанная";
            editTxtBlck.HorizontalAlignment = HorizontalAlignment.Right;
            editTxtBlck.VerticalAlignment = VerticalAlignment.Bottom;
            editTxtBlck.Foreground = Brushes.White;
            editTxtBlck.FontSize = 14;
            editTxtBlck.Margin = new Thickness(0, 0, 8, 0);
            grid.Children.Add(editTxtBlck);

            TextBlock editTxtBlckNum = new TextBlock();
            editTxtBlckNum.Text = editHeight.ToString();
            editTxtBlckNum.HorizontalAlignment = HorizontalAlignment.Right;
            editTxtBlckNum.VerticalAlignment = VerticalAlignment.Bottom;
            editTxtBlckNum.Foreground = Brushes.White;
            editTxtBlckNum.FontSize = 18;
            editTxtBlckNum.Margin = new Thickness(0, 0, 50, 30);
            grid.Children.Add(editTxtBlckNum);

            TextBlock frequencyOfOccurrence = new TextBlock();
            frequencyOfOccurrence.Text = "Частоты появлений";
            frequencyOfOccurrence.HorizontalAlignment = HorizontalAlignment.Center;
            frequencyOfOccurrence.VerticalAlignment = VerticalAlignment.Top;
            frequencyOfOccurrence.Foreground = Brushes.White;
            frequencyOfOccurrence.FontSize = 18;
            grid.Children.Add(frequencyOfOccurrence);
        }
    }
}
