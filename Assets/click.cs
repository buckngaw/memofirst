using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

    public int myValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        if (Input.GetKey("mouse 0"))
        {
            myValue++;
            print("Box Clicked!");
        }
    }
}
