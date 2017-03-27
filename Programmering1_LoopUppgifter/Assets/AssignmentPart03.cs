using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AssignmentPart03 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // This is the thrird part/step in the assignment.

        // The objectiv is to create a loop that will turn the list so the 
        // first element will be last and the last one first.

        List<int> listPart = new List<int>();

        listPart.Add(10);
        listPart.Add(20);
        listPart.Add(30);
        listPart.Add(40);
        listPart.Add(50);

        for (int a = listPart.Count-1; a >= 0; a--)

        {
            print(listPart[a]);


        }
    }
}