using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panda3Movement : MonoBehaviour {

    Vector3 pos;
    Vector2 clickPos;
    private bool left = false;
    private bool right = false;
    public bool enable = false;
    public bool consent = false;
    private Animator animator;
    public Camera cam;

    public float speedMult;

    void Start () {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        MouseMove();
        animator.SetBool("left", left);
        animator.SetBool("right", right);
        animator.SetBool("consent", consent);
    }
   

    private void MouseMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPos = Input.mousePosition;
            //clickPos = cam.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log(clickPos);
            //Debug.DrawRay(Vector2.zero, clickPos, Color.cyan);
            if (clickPos.x > 550)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(speedMult, 0);
                right = true;
                left = false;
            }
            if (clickPos.x <= 550)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speedMult, 0);
                right = false;
                left = true;
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            right = false;
            left = false;
        }
        if (this.transform.position.x >= 20)
        {
            this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            left = false;
            right = false;
            enable = true;
            
        }
        if (this.transform.position.x <= -5)
        {
            this.transform.position += new Vector3(5, 0, 0);
        }
    }

    void stopWalk()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    void WalkSound()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep1");
    }

    void WalkSound2()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep2");
    }
    void Wave()
    {
        FindObjectOfType<AudioManager>().Play("wave");
    }
}
