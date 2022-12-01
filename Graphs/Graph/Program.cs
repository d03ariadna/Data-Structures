using Graphs;

internal class Program
{
    private static void Main(string[] args)
    {
        Graph graph = new Graph();

        graph.InsertV("A");
        graph.InsertV("B");
        graph.InsertV("C");
        graph.InsertV("D");
        graph.InsertV("E");
        graph.InsertV("F");
        graph.InsertV("G");
        graph.InsertV("H");
        graph.InsertV("I");
        graph.InsertV("J");
        graph.InsertV("K");
        graph.InsertV("L");
        //graph.InsertV("M");
        //graph.printMat();

        //graph.InsertEdge("A", 2, "B");
        //graph.InsertEdge("A", 1, "C");
        //graph.InsertEdge("A", 5, "D");
        //graph.InsertEdge("B", 8, "E");
        //graph.InsertEdge("B", 5, "F");
        //graph.InsertEdge("C", 9, "G");
        //graph.InsertEdge("D", 3, "H");
        //graph.InsertEdge("D", 5, "I");
        //graph.InsertEdge("E", 7, "J");
        //graph.InsertEdge("F", 4, "J");
        //graph.InsertEdge("F", 8, "K");
        //graph.InsertEdge("G", 4, "K");
        //graph.InsertEdge("H", 5, "K");
        //graph.InsertEdge("H", 7, "L");
        //graph.InsertEdge("I", 2, "L");

        //graph.InsertEdge("J", 4, "L");
        //graph.InsertEdge("J", 1, "K");
        //graph.InsertEdge("K", 3, "J");
        //graph.InsertEdge("K", 1, "L");
        //graph.InsertEdge("L", 2, "J");
        //graph.InsertEdge("L", 1, "K");

        graph.printMat();

        //graph.printEdges("B");

        //graph.DeleteV("A");
        //graph.DeleteEdge("A", "B");
        //graph.printMat();

        //graph.printTraversing("A", 'D');
        //graph.printTraversing("A", 'B');

        Console.WriteLine("Shortest path from A to K:");
        graph.FindPath("K");




    }
}