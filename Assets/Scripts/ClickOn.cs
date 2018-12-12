using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOn : MonoBehaviour {

    private bool wear = false;
    public bool stand = false;
    private bool walk = false;
    private Animator animator;
    public GameObject baby;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            if(wear)
            walk = true;
        }

        animator.SetBool("stand", stand);
        animator.SetBool("wear", wear);
        animator.SetBool("walk", walk);
	}

    public void ClickMe()
    {
        if(stand == true)
        {
            wear = true;
            baby.SetActive(false);
            Debug.Log("wear!");
        }
       
    }

    void wearClothes()
    {
        FindObjectOfType<AudioManager>().Play("wear");
    }
    void WalkSound()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep1");
    }

    void WalkSound2()
    {
        FindObjectOfType<AudioManager>().Play("panda2footstep2");
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
