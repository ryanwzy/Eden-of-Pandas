using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panda4 : MonoBehaviour {

    public GameObject partner;
    public GameObject mosaic1;
    public GameObject mosaic2;
    private Animator animator;
    private Vector2 mouseDownPos;
    public bool beClicked = false;
    public bool takeOff1 = false;
    public bool takeOff2 = false;
    public bool naked = false;
    private bool back = false;
    private bool grow = false;

    void Start () {
        animator = this.GetComponent<Animator>();
  
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            grow = true;
            Debug.Log("Click down");

            if (animator.GetCurrentAnimatorStateInfo(0).IsName("wear4"))
            {
                FindObjectOfType<sunset>().Sunset = true;
            }

            if (naked)
            {
                back = true;
                FindObjectOfType<Sun4>().closeEye = true;
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Click up");
            if (Input.GetAxis("Mouse Y") > 0 && beClicked)
            {
                takeOff1 = true;

                FindObjectOfType<Sun42>().closeEye = true;
                Debug.Log("take off 1");
            }
            else if (Input.GetAxis("Mouse Y") < 0 && beClicked && takeOff1 == true)
            {
                //if (beClicked == true)
                //
                takeOff2 = true;

                FindObjectOfType<Sun43>().closeEye = true;

                Debug.Log("take off 2");
                //}
            }
           //takeOff1 = false;
            //takeOff2 = false;
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("naked"))
        {
            naked = true;
        }


        animator.SetBool("takeoff1", takeOff1);
        animator.SetBool("takeoff2", takeOff2);
        animator.SetBool("back", back);
        animator.SetBool("grow", grow);

    }

    void ReplaceObjects()
    {
        mosaic1.SetActive(true);
        mosaic2.SetActive(true);
        partner.SetActive(true);
    }

    void clearFirst()
    {
        mosaic1.SetActive(false);
    }
    void clearSecond()
    {
        mosaic2.SetActive(false);
    }

    void outPool()
    {
        FindObjectOfType<AudioManager>().Play("outPool");
    }

    void takeOffClothes()
    {
        FindObjectOfType<AudioManager>().Play("wear");
    }

}
