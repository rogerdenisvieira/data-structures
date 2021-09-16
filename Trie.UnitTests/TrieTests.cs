using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Trie.UnitTests
{
    public class TrieTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GivenAListOfWords_WhenSearchForAPrefix_ThenRetrieveWords()
        {
            Trie trie = new Trie();

            var providedWords = new List<string>() { "abacate", "abraço", "abertura", "abrir", "amigo" };
            var expectedWords = new List<string>() { "abacate", "abraço", "abertura", "abrir" };

            providedWords.ForEach(x => {trie.Insert(x);});

            var foundWords = trie.FindByPrefix("ab");

            Assert.IsTrue(foundWords.Count == 4);

            expectedWords.Sort();
            foundWords.Sort();

            Assert.IsTrue(Enumerable.SequenceEqual(expectedWords, foundWords));
            
        }
    }
}