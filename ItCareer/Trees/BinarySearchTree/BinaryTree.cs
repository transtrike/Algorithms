using System;

namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public BinaryTree(T value, BinaryTree<T> leftNode = null, BinaryTree<T> rightNode = null)
        {
            this.Value = value;
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
        }

        public T Value { get; private set; }
        public BinaryTree<T> LeftNode { get; private set; }
        public BinaryTree<T> RightNode { get; private set; }


        public void DFS(Action<T> action) => this.DFS(this, action);
        public BinaryTree<T> Search(T value) => this.Search(value, this);
        public bool Contains(T value) => this.Search(value) != null;
        public void Insert(T value)
        {
            Insert(value, this);

            OrderTree();
        }

        private void Insert(T value, BinaryTree<T> tree)
        {
            if (tree.Value.CompareTo(value) > 0 && tree.LeftNode != null)
                Insert(value, tree.LeftNode);
            else if (tree.Value.CompareTo(value) < 0 && tree.RightNode != null)
                Insert(value, tree.RightNode);

        }

        private void DFS(BinaryTree<T> tree, Action<T> action)
        {
            action.Invoke(tree.Value);
            Rec(tree.LeftNode);
            Rec(tree.RightNode);

            void Rec(BinaryTree<T> node)
            {
                if (node != null)
                {
                    if (node.LeftNode == null)
                        action.Invoke(node.Value);
                    else if (node.RightNode == null)
                        action.Invoke(node.Value);
                    else
                        DFS(node, action);
                }
            }
        }

        private BinaryTree<T> Search(T value, BinaryTree<T> tree)
        {
            if (tree.LeftNode == null && tree.RightNode == null)
                return null;

            if (tree.Value.CompareTo(value) == 0)
                return tree;
            else if (tree.Value.CompareTo(value) < 0)
                return Search(value, tree.LeftNode);
            else if (tree.Value.CompareTo(value) > 0)
                return Search(value, tree.RightNode);
            else
                return null;
        }

        private void InsertNode(T value, BinaryTree<T> node)
        {
            if (node == null)
                node = new BinaryTree<T>(value);
            else
                Insert(value, node);
        }

        private void OrderTree()
        {
            //Order the tree using rotations
            /*
                if left nodes > right nodes
                    to the right rotation
                else if left nodes < right nodes
                    to the left roration
                else
                    return;
            */

            LeftRotation();
            //RightRotation();
        }

        private void LeftRotation()
        {
            BinaryTree<T> leftNode = this.LeftNode;

            leftNode = leftNode.RightNode;
            leftNode.RightNode = this;
        }
    }
}