using System;

namespace Scrambler.Classes
{
    public class Decrypt
    {
        public bool DecryptionAlgorithmNumberWord(ref string txtLine, ref string txtKey)
        {
            try
            {
                if (txtKey == "")
                    throw new Exception();
                // идентификация ключа
                char[] key = txtKey.ToCharArray();
                int numKey = 0;
                for (int i = 0; i < key.Length; ++i)
                    numKey += (int)key[i];

                // дешифрование строки
                string line = "";
                char[] text = txtLine.ToCharArray();

                for (int i = 0; i < txtLine.Length; ++i)
                {
                    text[i] = (char)((int)text[i] ^ numKey);
                    line += text[i];
                }

                //передача параметра
                txtLine = line;
                txtKey = "";
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DecryptionAlgorithmCodeNumber(ref string txtLine, ref string txtKey)
        {
            try
            {
                if (txtKey == "" || (txtKey.Length > 0 && txtLine.Length == 0))
                    throw new Exception();
                // инициализация ключа
                char[] key = txtKey.ToCharArray();

                // дешифрование строки
                string textLine = "";
                char[] text = txtLine.ToCharArray();

                for (int i = 0; i < txtLine.Length; ++i)
                {
                    text[i] = (char)((int)text[i] ^ (int)key[i]);
                    textLine += text[i];
                }

                // передача параметров
                txtLine = textLine;
                txtKey = "";
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DecryptionAlgorithmCodeASCII(ref string txtLine, ref string txtKey)
        {
            try
            {
                if (txtKey == "" || txtKey.Length != (txtLine.Length - (txtLine.Length/2)))
                    throw new Exception();
                // инициализация ключа
                char[] key = txtKey.ToCharArray();
                int[] displacement = new int[key.Length];

                for (int i = 0; i < displacement.Length; ++i)
                {
                    string str = Convert.ToString((char)key[i]);
                    displacement[i] = Convert.ToInt32(str);
                }

                // дешифрование строки
                string displacementLine = "";
                char[] buffText = txtLine.ToCharArray();

                for (int i = 0; i < buffText.Length; ++i)
                {
                    if ((i + 3) % 2 == 0)
                    {
                        continue;
                    }
                    displacementLine += buffText[i];
                }

                char[] buff = displacementLine.ToCharArray();
                string line = "";
                for (int i = 0; i < displacementLine.Length; ++i)
                {
                    int code = (int)((int)buff[i] + displacement[i]);
                    line += (char)code;
                }

                // передача параметров
                txtKey = "";
                txtLine = line;
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
