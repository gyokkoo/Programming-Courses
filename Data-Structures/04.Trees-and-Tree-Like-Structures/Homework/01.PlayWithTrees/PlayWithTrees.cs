namespace _01.PlayWithTrees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayWithTrees
    {
        private static Dictionary<int, Tree<int>> nodeByValue;
        private static int longestPath;
        private static Tree<int> longestPathLeaf;
        private static int pathSum;

        public static void Main(string[] args)
        {
            int nodesCount = int.Parse(Console.ReadLine());
            nodeByValue = new Dictionary<int, Tree<int>>(nodesCount);

            for (int i = 1; i < nodesCount; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');
                int parentValue = int.Parse(edge[0]);
                Tree<int> parentNode = GetTreeNodeByValue(parentValue);
                int childValue = int.Parse(edge[1]);
                Tree<int> childNode = GetTreeNodeByValue(childValue);
                parentNode.Children.Add(childNode);
                childNode.Parent = parentNode;
            }

            pathSum = int.Parse(Console.ReadLine());
            int subTreeSum = int.Parse(Console.ReadLine());

            // Root node
            var rootVertex = FindRootNode();
            Console.WriteLine("Root node: {0}{1}", rootVertex.Value, Environment.NewLine);

            // Leaf nodes
            var leafNodes = FindLeafNodes().OrderBy(node => node.Value);
            Console.Write("Leaf nodes: ");
            foreach (var node in leafNodes)
            {
                Console.Write(node.Value + " ");
            }

            Console.WriteLine(Environment.NewLine);

            // Middle nodes
            var middleNodes = FindMiddleNodes().OrderBy(node => node.Value);
            Console.Write("Middle nodes: ");
            foreach (var node in middleNodes)
            {
                Console.Write(node.Value + " ");
            }

            Console.WriteLine(Environment.NewLine);

            // Longest path
            Console.WriteLine("Longest path:");
            FindLongestPath(rootVertex);
            var longestPathStack = GetPathValues(longestPathLeaf);
            Console.WriteLine("{0} (length = {1}){2}", string.Join(" -> ", longestPathStack), longestPath, Environment.NewLine);

            // Paths of given sum
            Console.WriteLine("Paths of sum {0}:", pathSum);
            PrintAllPathsWithSum(rootVertex, rootVertex.Value);
            Console.WriteLine();

            // Subtrees of sum given
            
            // TODO
        }

        private static Tree<int> GetTreeNodeByValue(int value)
        {
            if (!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value);
            }

            return nodeByValue[value];
        }

        private static Tree<int> FindRootNode()
        {
            var rootNode = nodeByValue.Values.FirstOrDefault(node => node.Parent == null);

            return rootNode;
        }

        private static IEnumerable<Tree<int>> FindLeafNodes()
        {
            var leafNodes = nodeByValue.Values
                .Where(node => node.Children.Count == 0 && node.Parent != null);

            return leafNodes;
        }

        private static void PrintAllPathsWithSum(Tree<int> tree, int sum)
        {
            if (sum == pathSum)
            {
                var path = GetPathValues(tree);
                Console.WriteLine(string.Join(" -> ", path));   
            }

            foreach (var child in tree.Children)
            {
                PrintAllPathsWithSum(child, sum + child.Value);
            }
        }

        private static IEnumerable<Tree<int>> FindMiddleNodes()
        {
            var middleNodes = nodeByValue.Values
                .Where(node => node.Children.Count > 0 && node.Parent != null);

            return middleNodes;
        }

        private static IEnumerable<int> GetPathValues(Tree<int> tree)
        {
            var result = new Stack<int>();
            while (tree != null)
            {
                result.Push(tree.Value);
                tree = tree.Parent;
            }

            return result;
        }

        private static void FindLongestPath(Tree<int> tree, int depth = 1)
        {
            if (depth > longestPath)
            {
                longestPath = depth;
                longestPathLeaf = tree;
            }

            foreach (var child in tree.Children)
            {
                FindLongestPath(child, depth + 1);
            }
        }
    }
}
