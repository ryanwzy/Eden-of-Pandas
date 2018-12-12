using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public GameObject partner;
    private Animator animator;
    private Animator sun;
    private bool left = false;
    private bool right = false;
    private bool stop = false;
    public float distance = 0;
    Vector2 mouseDownPos;
    public AudioSource walk;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(GetComponent<Drag>().born == true){
            if (Input.GetMouseButtonDown(0))
            {
                mouseDownPos = Input.mousePosition;
                Vector2 touchPos = Camera.main.ScreenToWorldPoint(mouseDownPos);
                if (touchPos.x > -3.7f)
                {
                    distance += 1;
                    right = true;

                }
                if (touchPos.x < -3.7f)
                {
                    distance += 1;
                    left = true;
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                left = false;
                right = false;
            }

        }

        if(distance>6){
            partner.GetComponent<Set>().move = true;
            distance++;

            //GetComponent<Walk>().enabled = false;
        }
        if (distance > 40)
        {
            stop = true;
            if(Input.GetMouseButtonDown(0))
            partner.GetComponent<Set>().set = true;
        }

        animator.SetBool("left", left);
        animator.SetBool("right", right);
        animator.SetBool("stop", stop);
    }

    void WalkSound()
    {
        //walk.Play();
        FindObjectOfType<AudioManager>().Play("walk");
    }

    void WalkSound2()
    {
        //walk.Play();
        FindObjectOfType<AudioManager>().Play("walk2");
    }


}
    
