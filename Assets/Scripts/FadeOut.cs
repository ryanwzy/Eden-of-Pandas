using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour {

    private Animator animator;
    public bool fade = false;


	void Start () {
        animator = GetComponent<Animator>();
        animator.speed = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(fade == true)
        {
            animator.speed = 1;
        }
	}

    void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
