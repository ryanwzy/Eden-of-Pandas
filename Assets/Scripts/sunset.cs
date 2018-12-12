using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunset : MonoBehaviour {

    private Animator animator;
    public bool Sunset = false;

    void Start () {
        animator = GetComponent<Animator>();
        animator.speed = 0f;
	}
	
	
	void Update ()
    {
        if (Sunset)
        {
            animator.speed = 1;
            FindObjectOfType<Sun4>().openEye = true;
            FindObjectOfType<Sun42>().openEye = true;
            FindObjectOfType<Sun43>().openEye = true;
        }
    }
}
