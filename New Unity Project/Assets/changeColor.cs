using UnityEngine;
using System.Collections;

public class changeColor : MonoBehaviour {
     // Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.R))
			GetComponent<Renderer>().material.color = Color.red;
            print("Changed color to red.");
        // turns object RED

        if (Input.GetKeyDown(KeyCode.Delete))
            GetComponent<Renderer>().material.color = Color.white;
        print("Changed color to white.");
        // turns object WHITE

        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Renderer>().material.color = Color.black;
        print("Changed color to black.");
        // turns object BLACK

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
            GetComponent<Renderer>().material.color = Color.yellow;
        print("Changed color to yellow.");
        // turns color YELLOW

        if (Input.GetKeyDown(KeyCode.G))
			GetComponent<Renderer>().material.color = Color.green;		
        // turns color GREEN

		if (Input.GetKeyDown(KeyCode.B))
			GetComponent<Renderer>().material.color = Color.blue;
        // turns color BLUE
	}

}