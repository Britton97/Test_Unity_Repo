using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    public GameObject playerObj;
    Player player;
    public bool drawCubes;

    public Vector2Int gridWorldSize;
    public Vector3 bottomLeft;
    [Range(.5f, 10)]
    float nodeRadius = .5f;
    public float nodeDiameter;

    public Node[,] nodeArray;

    private void Start()
    {
        SetUp();
        NodeSetUp();
    }

    private void NodeSetUp()
    {
        int howManyNodesX = gridWorldSize.x / (int)nodeDiameter;
        int howManyNodesY = gridWorldSize.y / (int)nodeDiameter;
        Vector2 nodePos = new Vector2(bottomLeft.x, bottomLeft.z);

        for (int x = 0; x < howManyNodesX; x++)
        {
            float PosX = x;
            float actX = PosX + nodePos.x;

            for (int y = 0; y < howManyNodesY; y++)
            {
                float posY = y;
                float actY = posY + nodePos.y;
                Node newNode = new Node(PosX, posY, actX, actY);
                newNode.occupied = false;
                nodeArray[x, y] = newNode;
            }
        }
    }
    private void SetUp()
    {
        player = playerObj.GetComponent<Player>();

        nodeArray = new Node[gridWorldSize.x, gridWorldSize.y];
        nodeDiameter = nodeRadius * 2;

        if (gridWorldSize.x % 2 != 0)
        {
            gridWorldSize.x++;
        }

        if (gridWorldSize.y % 2 != 0)
        {
            gridWorldSize.y++;
        }
        bottomLeft = new Vector3(
            (transform.position.x - gridWorldSize.x / 2 + nodeRadius), 0, (transform.position.z - gridWorldSize.y / 2 + nodeRadius));

        player.bottomLeft = bottomLeft;
        player.gridSize = gridWorldSize;
    }

    private void OnDrawGizmos()
    {
        if (drawCubes)
        {
            Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, 1, gridWorldSize.y));
            if (nodeArray != null)
            {
                foreach (Node n in nodeArray)
                {
                    Gizmos.color = (n.occupied) ? Color.red : Color.clear; //if tile is occupied then red else white
                    Gizmos.DrawWireCube(new Vector3(n.actPosX, 0, n.actPosY), new Vector3(.9f, 1, .9f));
                }
            }

        }
    }
}
