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
        ColorChanger();
    }

    private void ColorChanger()
    {
        if (Input.GetKey(KeyCode.R))
        {
            if (Input.GetKey(KeyCode.G))
            {
                myRenderer.material.color = Color.yellow;
            }
            else if (Input.GetKey(KeyCode.B))
            {
                myRenderer.material.color = Color.magenta;
            }
            else
            {
                myRenderer.material.color = Color.red;
            }
        }
        else if (Input.GetKey(KeyCode.G))
        {
            if (Input.GetKey(KeyCode.B))
            {
                myRenderer.material.color = Color.cyan;
            }
            else
            {
                myRenderer.material.color = Color.green;
            }
        }
        else if (Input.GetKey(KeyCode.B))
        {
            myRenderer.material.color = Color.blue;
        }
        else
        {
            myRenderer.material.color = Color.white;
        }

        if (Input.GetKey(KeyCode.B) && Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.R))
        {
            myRenderer.material.color = Color.black;
        }
    }
}
