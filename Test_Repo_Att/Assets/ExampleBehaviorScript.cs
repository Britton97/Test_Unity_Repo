using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleBehaviorScript : MonoBehaviour
{
    Renderer myRenderer;
    private void Start()
    {
        myRenderer = GetComponent<Renderer>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            myRenderer.material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            myRenderer.material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            myRenderer.material.color = Color.blue;
        }
    }
}
