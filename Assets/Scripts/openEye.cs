using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openEye : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void EyeOpen()
    {
        FindObjectOfType<AudioManager>().Play("openEye");
    }
}
