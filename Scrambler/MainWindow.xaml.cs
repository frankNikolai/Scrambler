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

namespace Scrambler
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            string keyText = TxKey.Text;
            string lineText = TxLine.Text;
            
            if (ComboBoxMethodEncryptionAndDecryption.Text == "Зашифровать")
            {
                Classes.Encrypt encrypt = new Classes.Encrypt();
                if (ComboBoxMethod.Text == "Код")
                {
                    encrypt.EncryptionAlgorithmNumberWord(ref lineText, ref keyText);
                    TxLine.Text = lineText;
                    TxKey.Text = keyText;
                }
                else if (ComboBoxMethod.Text == "Код:очередность")
                {
                    encrypt.EncryptionAlgorithmCodeNumber(ref lineText, ref keyText);
                    TxLine.Text = lineText;
                    TxKey.Text = keyText;
                }
                else
                {
                    encrypt.EncryptionAlgorithmCodeASCII(ref lineText, ref keyText);
                    TxLine.Text = lineText;
                    TxKey.Text = keyText;
                }
            }
            else 
            {
                Classes.Decrypt decrypt = new Classes.Decrypt();

                if (ComboBoxMethod.Text == "Код")
                {
                    decrypt.DecryptionAlgorithmNumberWord(ref lineText, ref keyText);
                    TxLine.Text = lineText;
                    TxKey.Text = keyText;
                }
                else if (ComboBoxMethod.Text == "Код:очередность")
                {
                    decrypt.DecryptionAlgorithmCodeNumber(ref lineText, ref keyText);
                    TxLine.Text = lineText;
                    TxKey.Text = keyText;
                }
                else
                {
                    int editHeight = symbolFrequency(TxLine.Text);

                    decrypt.DecryptionAlgorithmCodeASCII(ref lineText, ref keyText);
                    TxLine.Text = lineText;
                    TxKey.Text = keyText;

                    int firstHeight = symbolFrequency(TxLine.Text);

                    Diagrams diagrams = new Diagrams(firstHeight, editHeight);
                    diagrams.Show();


                }
            }
        }

        int symbolFrequency(string input)
        {
            char[] line = input.ToCharArray();

            int count = 0;

            for (int i = 0; i < line.Length ; ++i)
            {
                for (int j = i + 1; j < line.Length; ++j)
                {
                    if (line[i] == line[j] && line[j] != ' ')
                    {
                        count++;

                        line[j] = ' ';
                    }
                }
            }

            return count;
        }
    }
}
