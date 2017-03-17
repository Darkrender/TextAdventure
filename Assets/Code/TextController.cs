using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;

	// Use this for initialization
	void Start ()
    {
        text.text = "Hello world";
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "TREACHERY! You were framed for a theft you did not commit and are now locked in a prison cell. " +
                        "There are some dirty sheets on the bed, a mirror on the wall, and a door. " +
                        "The door is locked from the outside and there are thick bars on the door's window. \n\n" +
                        "Press S to inspect the Sheets\n" +
                        "Press M to inspect the Mirror\n" +
                        "Press L to inspect the Lock";
        }
	}
}
