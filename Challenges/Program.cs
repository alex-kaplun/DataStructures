using System;
using System.Collections.Generic;
using System.IO;
using Challenges;
class Solution
{
	static void Main(String[] args)
	{
		BinaryTree myTree = new BinaryTree();
		Node root = null;

		int t;
		int data;

		t = Convert.ToInt32(Console.ReadLine());
		while (t-- > 0)
		{
			data = Convert.ToInt32(Console.ReadLine());
			myTree.Insert(root, data);
		}

		//int height = myTree.Height();
		//Console.WriteLine(height);
		myTree.LevelOrderTraversal();
	}
}