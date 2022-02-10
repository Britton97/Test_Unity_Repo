using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    private void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
