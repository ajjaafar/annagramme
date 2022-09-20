using NUnit.Framework;
using projet_test.Interface;
using projet_test.Service;

namespace projettest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CheckStringOk()
        {
            IAnagrammeService anagrammeService = new AnagrammeService();
            string word1 = "Arbre";//"arbre"
            string word2 = "Barre";//"barre"
    
            var result= anagrammeService.IsAnagramme(word1, word2);
            Assert.IsTrue(result);
        }

        [Test]
        public void CheckStringKO()
        {
            IAnagrammeService anagrammeService = new AnagrammeService();
            string word1 = "Arbre";
            string word2 = "Camion";
            var result = anagrammeService.IsAnagramme(word1, word2);
            Assert.IsFalse(result);
        }
    }
}