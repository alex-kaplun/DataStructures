using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
	public class Node
	{
		public int Data
		{ get; set; }
		public Node Left
		{ get; set; }
		public Node Right
		{ get; set; }

		public Node(int data)
		{
			Data = data;
			Left = null;
			Right = null;
		}		
	}


	public class BinaryTree
	{
		private Node _root;
		public BinaryTree(int data)
		{
			_root = new Node(data);
		}

		public BinaryTree()
		{
			_root = null;
		}

		public void Insert(Node root, int data)
		{
			_root = _root.AddChild(data);
		}

		private int NodeHeight(Node root, int curHeight = 0)
		{
			if (null == root)
			{
				return 0;
			}
			if ((null == root.Left) && (null == root.Right))
			{
				return curHeight;
			}
			int leftHeight = NodeHeight(root.Left, curHeight + 1);
			int rightHeight = NodeHeight(root.Right, curHeight + 1);
			return leftHeight > rightHeight ? leftHeight : rightHeight;
		}

		public int Height()
		{
			return NodeHeight(_root, 0);
		}

		public void LevelOrderTraversal()
		{
			int height = Height();
			for (int level = 0; level < height; level++)
			{
				PrintTreeLevel(_root, level);
			}
		}

		private void PrintTreeLevel(Node rootNode, int level)
		{
			if (null == rootNode)
			{
				return;
			}
			if (level == 0)
			{
				Console.Write(String.Format("{0} ", rootNode.Data));
			}
			else
			{
				PrintTreeLevel(rootNode.Left, level - 1);
				PrintTreeLevel(rootNode.Right, level - 1);
			}
		}
	}

	public static class NodeMethods
	{

		public static Node AddChild(this Node root, int data)
		{
			if (null == root)
			{
				return new Node(data);
			}
			Node curNode;
			if (data <= root.Data)
			{
				curNode = AddChild(root.Left, data);
				root.Left = curNode;
			}
			else
			{
				curNode = AddChild(root.Right, data);
				root.Right = curNode;
			}
			return root;
		}
	}
}