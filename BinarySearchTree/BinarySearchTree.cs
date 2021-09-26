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

            Node newNode = new Node() { Data = value };

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }
            }

            return true;
            

        }

        public Node Find(int value)
        {
            return this.Find(value, this.Root);
        }

        public void Remove(int value)
        {
            this.Root = Remove(this.Root, value);
        }

        private Node Remove(Node parent, int key)
        {
            if (parent == null)
            {
                return parent;
            }

            if (key < parent.Data)
            {
                parent.LeftNode = Remove(parent.LeftNode, key);
            }
            else if (key > parent.Data)
            {
                parent.RightNode = Remove(parent.RightNode, key);
            }
            else
            {
                if (parent.LeftNode == null)
                {
                    return parent.RightNode;
                }
                else if (parent.RightNode == null)
                {
                    return parent.LeftNode;
                }

                parent.Data = MinValue(parent.RightNode);

                parent.RightNode = Remove(parent.RightNode, parent.Data);
            }

            return parent;
        }

        private int MinValue(Node node)
        {
            int minValue = node.Data;

            while (node.LeftNode != null)
            {
                minValue = node.LeftNode.Data;
                node = node.LeftNode;
            }

            return minValue;
        }

        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data)
                {
                    return parent;
                }

                if (value < parent.Data)
                {
                    return Find(value, parent.LeftNode);
                }
                else
                {
                    return Find(value, parent.RightNode);
                }
            }
            return null;
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        public int GetTreeDepth(Node node)
        {
            return node == null ? 0 : Math.Max(GetTreeDepth(node.LeftNode), GetTreeDepth(node.RightNode)) + 1;
        }

        public void TraversePreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");
                TraversePreOrder(node.LeftNode);
                TraversePreOrder(node.RightNode);
            }
        }

        public void TraverseInOrder(Node node)
        {
            if (node != null)
            {
                TraverseInOrder(node.LeftNode);
                Console.Write(node.Data + " ");
                TraverseInOrder(node.RightNode);
            }
        }

        public void TraversePostOrder(Node node)
        {
            if (node != null)
            {
                TraversePostOrder(node.LeftNode);
                TraversePostOrder(node.RightNode);
                Console.Write(node.Data + " ");
            }
        }

    }
}