using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 10f;
    public Quaternion currentRotation = Quaternion.Euler(0, 0, 0);
    public Quaternion targetRotation = Quaternion.Euler(0, 0, 0);
    List<Quaternion> rotationValues = new List<Quaternion>() 
    {Quaternion.Euler(0,0,0),
    Quaternion.Euler(0,0,90),
    Quaternion.Euler(0,0,180),
    Quaternion.Euler(0,0,270),
    Quaternion.Euler(0,0,0),
    Quaternion.Euler(90,0,0)};
    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = currentRotation;
        counter = rotationValues.Count -1;
        print(rotationValues.Count);
    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter();
        //PrintUpVector();
    }

    private void moveCharacter()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            counter = (counter < rotationValues.Count - 1)? counter += 1 : counter = 0;
            targetRotation = rotationValues[counter];
        }
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetRotation, 4.0f * Time.deltaTime );
    }

    private void PrintUpVector()
    {
        print(transform.up);
    }
}
