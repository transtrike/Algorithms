namespace MaxSumPathInBinaryTree
{
    public class BinaryTree<T>
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
    }
}