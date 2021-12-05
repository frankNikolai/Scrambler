using System;

namespace Scrambler.Classes
{
    public class Encrypt
    {
        Random random = new Random();
        public bool EncryptionAlgorithmNumberWord(ref string txtLine, ref string txtKey)
        {
            try
            {
                if (txtLine == "" || txtKey.Length > 0)
                    throw new Exception();
                // формирование ключа
                string keyLine = "";
                char[] key = new char[15];

                for (int i = 0; i < key.Length; ++i)
                    key[i] = (char)random.Next(0, 256);

                for (int i = 0; i < key.Length; ++i)
                {
                    char temp = key[i];
                    int rand = random.Next(1, 4);
                    if (rand == 1)
                        key[i] = (char)random.Next(48, 58);
                    else if (rand == 2)
                        key[i] = (char)random.Next(65, 91);
                    else
                        key[i] = (char)random.Next(97, 123);
                    for (int j = 0; j < txtKey.Length; ++j)
                    {
                        if (temp == key[j])
                        {
                            key[j] = key[i];
                        }
                    }
                }
                for (int i = 0; i < key.Length; ++i)
                {
                    keyLine += key[i];
                }

                int numKey = 0;
                for (int i = 0; i < key.Length; ++i)
                    numKey += (int)key[i];

                // шифрование строки
                string textLine = "";
                char[] text = txtLine.ToCharArray();

                for (int i = 0; i < txtLine.Length; ++i)
                {
                    text[i] = (char)((int)text[i] ^ numKey);
                    textLine += text[i];
                }

                //передача параметров
                txtLine = textLine;
                txtKey = keyLine;
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool EncryptionAlgorithmCodeNumber(ref string txtLine, ref string txtKey)
        {
            try
            {
                if (txtLine == "" || txtKey.Length > 0)
                    throw new Exception();
                // формирование ключа
                string keyLine = "";
                char[] key = new char[10];

                for (int i = 0; i < key.Length; ++i)
                    key[i] = (char)random.Next(0, 256);

                for (int i = 0; i < key.Length; ++i)
                    keyLine += key[i];

                // шифрование строки
                string textLine = "";
                char[] text = txtLine.ToCharArray();

                for (int i = 0; i < txtLine.Length; ++i)
                {
                    text[i] = (char)((int)text[i] ^ (int)key[i]);
                    textLine += text[i];
                }

                // передача параметров
                txtLine = textLine;
                txtKey = keyLine;
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool EncryptionAlgorithmCodeASCII(ref string txtLine, ref string txtKey)
        {
            try
            {
                if (txtLine == "" || txtKey.Length > 0)
                    throw new Exception();
                // формирование ключа
                string lineKey = "";
                int[] displacement = new int[txtLine.Length];
                for (int i = 0; i < displacement.Length; ++i)
                {
                    displacement[i] = random.Next(1, 10);
                    lineKey += displacement[i];
                }

                // шифрование строки
                char[] buffText = txtLine.ToCharArray();
                string line = "";
                for (int i = 0; i < txtLine.Length; ++i)
                {
                    int code = (int)(buffText[i] - displacement[i]);
                    line += (char)code;
                    if (txtLine.Length - 1 != i)
                    {
                        line += (char)random.Next(0, 256);
                    }
                }

                // передача параметров
                txtLine = line;
                txtKey = lineKey;
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
