using System;

namespace MaxSumPathInBinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryTree<int> binaryTree = new BinaryTree<int>(7,
				new BinaryTree<int>(19,
					new BinaryTree<int>(3),
					new BinaryTree<int>(12)),
				new BinaryTree<int>(14,
					new BinaryTree<int>(23),
					new BinaryTree<int>(5)));

			Greedy(binaryTree);
		}

		static void Greedy(BinaryTree<int> tree)
		{
			if (IsLeaf(tree))
			{
				return;
			}
			else if (tree.LeftNode.Value >= tree.RightNode.Value)
			{
				System.Console.WriteLine(tree.LeftNode.Value);
				Greedy(tree.LeftNode);
			}
			else
			{
				System.Console.WriteLine(tree.RightNode.Value);
				Greedy(tree.RightNode);
			}
		}

		static bool IsLeaf(BinaryTree<int> tree)
		{
			if (tree.LeftNode == null && tree.RightNode == null)
				return true;
			else
				return false;
		}
	}
}
