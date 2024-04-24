using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode {

    public List<Edge> edgeList = new List<Edge>();
    public GraphNode path = null;
    public float f, g, h;
    public GraphNode cameFrom;

    private GameObject id;

    public GraphNode(GameObject i) {

        id = i;
        path = null;
    }

    public GameObject getID() {

        return id;
    }
}