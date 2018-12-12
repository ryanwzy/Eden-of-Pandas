using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk2 : MonoBehaviour {

    private bool move = false;
    public bool lastStep = false;
    private Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    void Update () {
        if (Input.GetMouseButton(0))
        {
            move = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            move = false;
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("idle-f"))
        {
            lastStep = true;
        }

        animator.SetBool("move", move);
    }

    void WalkSound()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep1");
    }

    void WalkSound2()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep2");
    }
}
