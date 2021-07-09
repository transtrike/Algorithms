using System;

namespace BinarySearchTree
{
    public static class Program
    {
        public static void Main()
        {
            //BinaryTree<int> tree = new BinaryTree<int>(7, 
            //    new BinaryTree<int>(19, 
            //        new BinaryTree<int>(1), 
            //        new BinaryTree<int>(12)), 
            //    new BinaryTree<int>(14, 
            //        new BinaryTree<int>(23), 
            //        new BinaryTree<int>(6)));

            BinaryTree<int> tree = new BinaryTree<int>(5, 
                new BinaryTree<int>(3, new BinaryTree<int>(2), new BinaryTree<int>(4)),
                new BinaryTree<int>(7));

            tree.Insert(6);

            tree.DFS(Console.WriteLine);
            //Console.WriteLine(tree.Contains(3245));
        }
    }
}
