using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour {


    private Animator animator;
    public bool born = false;
   
    Vector2 mouseDownPos;

	void Start () {
        animator = GetComponent<Animator>();
        animator.speed = 0;
    }


    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("clicked");
            //            Debug.Log(Input.mousePosition);

            mouseDownPos = Input.mousePosition;
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(mouseDownPos);
            Debug.Log(touchPos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (Input.GetAxis("Mouse Y") > 0)
            {
                Debug.Log("You dragged up!");
                animator.speed = 1;
                if (!born)
                {
                    FindObjectOfType<AudioManager>().Play("slide");
                }

                born = true;


            }
            else if (Input.mousePosition.y < mouseDownPos.y)
            {
                Debug.Log("You dragged down!");
            }
        }
         
        animator.SetBool("born", born);

    }
    }
