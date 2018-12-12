using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall3 : MonoBehaviour
{
    private bool fall;
    private Animator animator;
    private Rigidbody2D rb;
    public GameObject pandas;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
        animator.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < 1f && this.transform.position.y > 0.5f)
        {
            this.GetComponent<Rigidbody2D>().simulated = true;
           
            animator.speed = 1;

        }

        if(this.transform.position.y < -1.5f)
        {
            this.GetComponent<Rigidbody2D>().simulated = false;
            fall = true;
            this.transform.position = new Vector3(0, -0.1f, 0);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("baby-ground"))
        {
            animator.speed = 1;
            pandas.GetComponent<Animator>().enabled = false;
        }

        animator.SetBool("fall", fall);
    }
    void inPool()
    {
        FindObjectOfType<AudioManager>().Play("inPool");
    }

    void FadeOut()
    {
        FindObjectOfType<FadeOut>().fade = true;
    }
}