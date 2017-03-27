using UnityEngine;
using System.Collections.Generic;

public class AssignmentPart02 : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        // This is the second part/step in the assignment.

        // The objectiv is to create a loop that will find one element 
        // in the list and then print it out its index.

        List<int> listPart = new List<int>();

        // As before we are organizing the listParts in to diffrent element.

        listPart.Add(1);
        listPart.Add(2);
        listPart.Add(3);
        listPart.Add(4);
        listPart.Add(5);

        // This part of the code is searching for the same value in the list.
        // And later it is useing it to accessing the index.

        int searchValue = 4;

        for (int a = 0; a < listPart.Count; a++)
        {
            if (searchValue == listPart[a])
            print(a);


        }
    }
}
