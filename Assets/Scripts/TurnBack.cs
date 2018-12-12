using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    void WalkSound()
    {
        FindObjectOfType<AudioManager>().Play("walk");
    }

    void WalkSound2()
    {
        FindObjectOfType<AudioManager>().Play("walk2");
    }
}
