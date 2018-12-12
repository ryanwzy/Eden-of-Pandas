using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class babyWalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void babyWalkSound()
    {
        FindObjectOfType<AudioManager>().Play("babyWalk");
    }
}
