using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Partner3 : MonoBehaviour {

    public bool take = false;
    private bool walk = false;
    public bool consent = false;
    public bool ReadyToTake = false;
    private Animator animator;
    public GameObject panda3;
    public GameObject sun, eye, Camera, bg;
    public GameObject cave;

    Vector2 clickPos;
    public float speedMult;

	void Start () {
        animator = GetComponent<Animator>();
	}
	
	void Update () {

        if (consent == true)
        {
            ReadyToTake = true;
        }

        if (take)
        {
        
            Camera.transform.parent = null;
            bg.transform.parent = null;
            eye.transform.SetParent(bg.transform, false);
            sun.transform.SetParent(bg.transform, false);
            panda3.GetComponent<SpriteRenderer>().enabled = false;

            if (Camera.transform.position.x < 28)
            {
                Camera.transform.position += new Vector3(0.1f, 0f, 0f);
                bg.transform.position += new Vector3(0.1f, 0f, 0f);
            }
            else if (Camera.transform.position.x < 35)
            {
                Camera.transform.position += new Vector3(0.3f, 0f, 0f);
                bg.transform.position += new Vector3(0.3f, 0f, 0f);
            }
            else if (Camera.transform.position.x < 40)
            {
                Camera.transform.position += new Vector3(0.1f, 0f, 0f);
                bg.transform.position += new Vector3(0.1f, 0f, 0f);
            }
            MouseMove();
        }

        animator.SetBool("take", take);
        animator.SetBool("walk", walk);
        animator.SetBool("consent", consent);
    }

    void MouseMove()
    {
        if (Input.GetMouseButtonDown(0))
        {
            walk = true;

        }
    }

    void stopWalk()
    {
        this.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    void kiss()
    {
        FindObjectOfType<AudioManager>().Play("kiss");
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
    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
