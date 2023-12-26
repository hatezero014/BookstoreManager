using BookstoreManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BookstoreManager
{
    public class KMP
    {
        private static KMP instance;

        public static KMP Instance
        {
            get { if (instance == null) instance = new KMP(); return instance; }
            private set => instance = value;
        }

        private KMP() { }
        public bool SolveKMP(string text, string pattern)
        {
            int M = pattern.Length;
            int N = text.Length;

            List<int> lps = new List<int>(new int[Math.Max(M, 1)]);

            int len = 0;
            int i = 1;
            lps[0] = 0;

            while (i < M)
            {
                if (pattern[i] == pattern[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = 0;
                        i++;
                    }
                }
            }


            i = 0;
            int j = 0;

            while (i < N)
            {
                if (pattern[j] == text[i])
                {
                    j++;
                    i++;
                }

                if (j == M)
                {
                    return true;
                }
                else if (i < N && pattern[j] != text[i])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return false;
        }

    }
}
