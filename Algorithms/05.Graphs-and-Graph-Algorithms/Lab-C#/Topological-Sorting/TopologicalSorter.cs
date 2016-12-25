using System;
using System.Collections.Generic;
using System.Linq;

public class TopologicalSorter
{
    private Dictionary<string, List<string>> graph;
    private HashSet<string> visitedNodes;
    private LinkedList<string> sortedNodes;
    private HashSet<string> cycleNodes; 

    public TopologicalSorter(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    //public ICollection<string> TopSort()
    //{
    //    var predecessorsCount = new Dictionary<string, int>();
    //    foreach (var node in this.graph)
    //    {
    //        if (!predecessorsCount.ContainsKey(node.Key))
    //        {   
    //            predecessorsCount[node.Key] = 0;
    //        }

    //        foreach (var childNode in node.Value)
    //        {
    //            if (!predecessorsCount.ContainsKey(childNode))
    //            {
    //                predecessorsCount[childNode] = 0;
    //            }

    //            predecessorsCount[childNode]++;
    //        }
    //    }

    //    var removedNodes = new List<string>();
    //    while (true)
    //    {
    //        string nodeToRemove = this.graph.Keys.FirstOrDefault(n => predecessorsCount[n] == 0);
    //        if (nodeToRemove == null)
    //        {
    //            break;
    //        }

    //        foreach (var node in this.graph[nodeToRemove])
    //        {
    //            predecessorsCount[node]--;
    //        }

    //        this.graph.Remove(nodeToRemove);
    //        removedNodes.Add(nodeToRemove);
    //    }

    //    if (this.graph.Count > 0)
    //    {
    //        throw new InvalidOperationException("A cycle detected in the graph");
    //    }

    //    return removedNodes;
    //}

    public ICollection<string> TopSort()
    {
        this.visitedNodes = new HashSet<string>();
        this.sortedNodes = new LinkedList<string>();
        this.cycleNodes = new HashSet<string>();

        foreach (var node in this.graph.Keys)
        {
            this.TopSortDFS(node);
        }

        return this.sortedNodes;
    }

    private void TopSortDFS(string node)
    {
        if (this.cycleNodes.Contains(node))
        {
            throw new InvalidOperationException("A cycle detected in the graph");
        }

        if (!this.visitedNodes.Contains(node))
        {
            this.visitedNodes.Add(node);
            this.cycleNodes.Add(node);

            if (this.graph.ContainsKey(node))
            {
                foreach (var childNode in this.graph[node])
                {
                    this.TopSortDFS(childNode);
                }
            }

            this.cycleNodes.Remove(node);
            this.sortedNodes.AddFirst(node);
        }
    }
}
