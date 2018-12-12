using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partner4 : MonoBehaviour {

    private Animator animator;
    public bool back = false;

	void Start () {
        animator = GetComponent<Animator>();
	}
	
	void Update () {

        if(FindObjectOfType<panda4>().naked == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                back = true;
            }
        }

        animator.SetBool("back", back);
	}
    public void FadeOut()
    {
        FindObjectOfType<FadeOut>().fade = true;
    }
}
