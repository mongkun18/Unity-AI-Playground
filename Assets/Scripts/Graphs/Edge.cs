using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge {

    public GraphNode startNode;
    public GraphNode endNode;

    public Edge(GraphNode from, GraphNode to) {

        startNode = from;
        endNode = to;
    }
}