using System;
using System.Collections.Generic;
using System.Linq;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();

            var strings = new List<String>() { "abacate", "abraço", "abertura", "abrir", "amigo" };

            foreach (var word in strings)
            {
                trie.Insert(word);
            }

            var foundWords = trie.FindByPrefix("ab");

            foundWords.ForEach(x => { Console.WriteLine(x); });



            //strings.Where(x => x.StartsWith("ab")).ToList().ForEach(y => Console.WriteLine(y));

            //trie.InsertRange(strings);

            //var result = trie.Prefix("ab");

            //while (!result.IsLeaf())
            //{
            //    Console.WriteLine(result.Value);
            //}




        }
    }
}
