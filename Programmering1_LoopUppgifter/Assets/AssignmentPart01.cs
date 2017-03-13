using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AssignmentPart01 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        // This is the first part/step in this assingment.

        // the obijectiv is to make/create a loop that will
        // print out every value in to a list.

        List<int> listPart = new List<int>();

        // The listParts is organized in to diffrent element.

        listPart.Add(10);
        listPart.Add(20);
        listPart.Add(30);
        listPart.Add(40);
        listPart.Add(50);

        // This code will commplete this first step and it is
        // the loop code, The code that will print the elements
        // "that i wrote beffore" one by one until all of them 
        // are in a list from the first one "10" to the last one "50"
        // in the console.

        for (int a = 0; a < listPart.Count; a++)
        {
            print(listPart[a]);


        }
    }
}
