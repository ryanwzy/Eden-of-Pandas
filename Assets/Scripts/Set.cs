using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Set : MonoBehaviour {

    public bool openEye = false;
    public bool move;
    public bool set = false;
    private bool mouseClickDetect = false;
    private Animator animator;
    public GameObject panda;
    public GameObject sun;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 0;
        move = false;
    }

    void loadNextScene()
    {
        openEye = true;
        mouseClickDetect = true;
    }

    void Update () {
        if(move == true){
            animator.speed = 1;
        }

        if (set == true)
        {
            panda.SetActive(false);
        }

       if(mouseClickDetect == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Sex-1");
            }
        }

        animator.SetBool("move", move);
        animator.SetBool("set", set);
        sun.GetComponent<Animator>().SetBool("openEye", openEye);

    }

    void setGes()
    {
        FindObjectOfType<AudioManager>().Play("set");
    }
}

