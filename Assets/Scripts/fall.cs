using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (this.transform.position.y < 0.6f)
        {
            this.GetComponent<Rigidbody2D>().simulated = true;
            FindObjectOfType<AudioManager>().Play("falling");
        }

        if(this.transform.position.y < -3)
        {
            SceneManager.LoadScene("Leave-1");
        }
    }
}
