using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    public class Trie
    {
        private readonly Node _root;

        public Trie()
        {
            _root = new Node(' ');
        }

        public void Insert(string word)
        {
            if (Search(word))
            {
                return;
            }

            Node current = _root;
            Node pre;

            foreach (var character in word)
            {
                pre = current;
                Node child = current.GetChild(character);
                if (child != null)
                {
                    current = child;
                    child.Parent = pre;
                }
                else
                {
                    current.Children.AddLast(new Node(character));
                    current = current.GetChild(character);
                    current.Parent = pre;
                }
            }
            current.IsLeaf = true;
        }

        public bool Search(string word)
        {
            Node current = _root;
            foreach (var character in word)
            {
                if (current.GetChild(character) == null)
                {
                    return false;
                }
                else
                {
                    current = current.GetChild(character);
                }
            }

            if (current.IsLeaf)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Return a list of words beginning by the provided prefix
        /// </summary>
        /// <param name="prefix">The prefix used to search the words starts with</param>
        /// <returns></returns>
        public List<string> FindByPrefix(string prefix)
        {
            Node lastNode = _root;

            foreach (var character in prefix)
            {
                lastNode = lastNode.GetChild(character);

                if (lastNode == null)
                {
                    return new List<string>();
                }
            }
            return lastNode.GetWords();
        }
    }
}
