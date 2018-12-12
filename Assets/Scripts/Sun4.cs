using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun4 : MonoBehaviour {

    private Animator animator;
    public bool openEye = false;
    public bool closeEye = false;


    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {

        animator.SetBool("openEye", openEye);
        animator.SetBool("closeEye", closeEye);

    }
    void EyeOpen()
    {
        FindObjectOfType<AudioManager>().Play("openEye");
    }
}
