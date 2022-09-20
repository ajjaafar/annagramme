using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projet_test.Interface
{
    public interface IAnagrammeService
    {
        public bool IsAnagramme(string word1, string word2);
    }
}
