using System;
using System.Collections.Generic;

namespace Trie
{
    public class Node
    {

        public char Data { get; set; }
        public LinkedList<Node> Children { get; set; }
        public Node Parent { get; set; }
        public bool IsLeaf { get; set; }

        public Node(char c)
        {
            Data = c;
            Children = new LinkedList<Node>();
            IsLeaf = false;
        }

        public Node GetChild(char c)
        {
            if(Children != null)
            {
                foreach (var child in Children)
                {
                    if(child.Data == c)
                    {
                        return child;
                    }
                }
            }
            return null;
        }

        internal List<string> GetWords()
        {
            List<string> wordList = new List<string>();
            if (IsLeaf)
            {
                wordList.Add(this.ToString());
            }

            if(Children != null)
            {
                foreach (var child in Children)
                {
                    if(child != null)
                    {
                        wordList.AddRange(child.GetWords());
                    }
                }
            }
            return wordList;
        }

        public override string ToString()
        {
            if(Parent == null)
            {
                return "";
            }
            else
            {
                // Concat might not be the best option for this scenario
                return String.Concat(Parent.ToString(), Data);
            }
        }
    }
}

