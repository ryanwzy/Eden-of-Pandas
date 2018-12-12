using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class grow : MonoBehaviour {
    public Animator sun;
    private Animator animator;
    private bool openEye = false;
    private bool StartToGrow = false;
    private bool NextStep = false;

	void Start () {
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            StartToGrow = true;
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("grow"))
        {
            openEye = true;

            if (Input.GetMouseButton(0))
            {
                animator.speed = 1;
                FindObjectOfType<AudioManager>().Play("grow");
            }

            if (Input.GetMouseButtonUp(0))
            {
                animator.speed = 0;
            }
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsTag("walk"))
        {
            if(NextStep == false)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    NextStep = true;
                }

            }
            if(NextStep == true)
            {
                if (Input.GetMouseButtonUp(0))
                {
                    NextStep = false;
                }
            }
           
        }

        sun.SetBool("openEye", openEye);
        animator.SetBool("Start", StartToGrow);
        animator.SetBool("NextStep", NextStep);
    }

    void WalkSound()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep1");
    }

    void WalkSound2()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep2");
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void babyWalk()
    {
        FindObjectOfType<AudioManager>().Play("babyWalk");
    }

}
