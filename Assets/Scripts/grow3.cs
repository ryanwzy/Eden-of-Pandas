using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class grow3 : MonoBehaviour {

    public Animator sun;
    private Animator animator;
    private bool openEye = false;
    private bool StartToGrow = false;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("stand"))
        {
            FindObjectOfType<ClickOn>().stand = true;
        }

        sun.SetBool("openEye", openEye);
        animator.SetBool("Start", StartToGrow);

    }
    void babyWalk()
    {
        FindObjectOfType<AudioManager>().Play("babyWalk");
    }

}
