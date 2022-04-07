using System;
using System.Diagnostics;
using Dijkstra.NET.Graph;
using Dijkstra.NET.ShortestPath;
/// <summary>
/// Summary description for Class1
/// </summary>
public class RouteCalculator
{

    static void Main(string[] args)
    {


        var graph = new Graph<int, string>();

        graph.AddNode(1);
        graph.AddNode(2);
        graph.AddNode(3);
        graph.AddNode(4);

        graph.Connect(1, 2, 2, ""); //First node has key equal 1
        graph.Connect(2, 3, 3, "");
        graph.Connect(1,4,2,"");
        graph.Connect(3, 4, 0,"");

        calculateRoute(graph);
         
        // CodeRepository.fetchData();
        

    }



    // public void calculateRoute(string startPoint, string endPoint)
    public static void calculateRoute(Graph<int, string> graph)
    {

 
        ShortestPathResult result = graph.Dijkstra(1, 2); //result contains the shortest path

        var path = result.GetPath();

        Console.Write(path);

    }






}
