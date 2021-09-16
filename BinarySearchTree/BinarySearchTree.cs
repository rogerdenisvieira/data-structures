using System;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }


        public bool Add(int value)
        {
            Node before = null;
            Node after = this.Root;

            while (after != null)
            {
                before = after;

                if (value < after.Data)
                {
                    after = after.LeftNode;
                }
                else if (value > after.Data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }

        }

        public Node Find(int value)
        {
            throw new NotImplementedException();
        }

        public void Remove(int value)
        {
            throw new NotImplementedException();
        }

        private Node Remove(Node parent, int key)
        {
            throw new NotImplementedException();
        }

        private Node Find(int value, Node parent)
        {
            throw new NotImplementedException();
        }

    }
}