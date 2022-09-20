using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projet_test.Interface;

namespace projet_test.Service
{
    public class AnagrammeService: IAnagrammeService
    {
        public bool IsAnagramme(string word1, string word2) {
            word1 = word1.ToLower().Trim();
            word2 = word2.ToLower().Trim();

            if (word1.Length != word2.Length)
            {
                return false;
            }
            else
            {
                string firstwordsorted = string.Concat(word1.OrderBy(x => x));
                string secondewordsorted = string.Concat(word2.OrderBy(x => x));

                if (firstwordsorted == secondewordsorted)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

    }
}
