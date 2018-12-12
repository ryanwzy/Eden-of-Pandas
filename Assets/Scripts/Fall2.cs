using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fall2 : MonoBehaviour
{

    //private Animator animator;
    // Use this for initialization
    void Start()
    {
        //animator = GetComponent<Animator>();
        //animator.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y < 0.57f)
        {
            //animator.speed = 1;
            this.GetComponent<Rigidbody2D>().simulated = true;
            FindObjectOfType<AudioManager>().Play("falling");
            
        }

        if (this.transform.position.y < -2.5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
