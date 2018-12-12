using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Partner2 : MonoBehaviour {

    private bool consent = false;
    private bool set = false;
    private Animator animator;
    public GameObject panda2;

	// Use this for initialization
	void Start () {
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (FindObjectOfType<Walk2>().lastStep == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                consent = true;
                panda2.SetActive(false);
            }
        }


        if (consent)
        {
            if(Input.GetMouseButtonDown(0))
            {
                set = true;
            }
        }

        animator.SetBool("consent", consent);
        animator.SetBool("set", set);
	}


    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Wave()
    {
        FindObjectOfType<AudioManager>().Play("wave");
    }
    void Set()
    {
        FindObjectOfType<AudioManager>().Play("set");
    }
}
