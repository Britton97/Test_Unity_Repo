using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    float myFloat = 3.3f;
    int myInt = 3;
    string myString = "Hello World";
    char myChar = 'G';
    bool myBool = false;
    Animal myAnimal = new Animal("Cat", 6);
    public GameObject myCube;

    private void Start()
    {
        myAnimal.PrintMyInfo();
    }
}


public class Animal
{
    public string species;
    public int age;

    public void PrintMyInfo()
    {
        Debug.Log($"I am a {species} and my age is {age}");
    }

    public Animal(string mySpecies, int myAge)
    {
        species = mySpecies;
        age = myAge;
    }
}
