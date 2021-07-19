using System;

namespace DSAndAlgo.Trees.BinaryTrees
{
    class HeightOfABinaryTreeUsingRecursion
    {
        public Node root;

        /// <summary>
            /** I/P -
                HeightOfABinaryTreeUsingRecursion tree = new HeightOfABinaryTreeUsingRecursion();
                tree.root = new Node(1);
                tree.root.left = new Node(2);
                tree.root.right = new Node(3);
                tree.root.left.left = new Node(4);
                tree.root.left.left.left = new Node(5);
                Console.WriteLine("Height of tree is : " + tree.Height(tree.root));
            **/
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Height(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                int lHeight = Height(node.left);
                int rheight = Height(node.right);

                return 1 + Math.Max(lHeight, rheight);
            }
        }
    }
}
