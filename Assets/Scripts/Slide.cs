using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class Slide : MonoBehaviour {

    private Animator animator;
    [SerializeField] bool sex1=false;
    [SerializeField] bool sex2=false;
    Vector2 mousePos;
    public GameObject baby;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(DelayAnimator());
    }

     IEnumerator DelayAnimator()
    {
        animator.speed = 0;
        yield return new WaitForSeconds(1);
        animator.speed = 1;
    }

    void Update () {
        mousePos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
        if (Input.GetAxis("Mouse X") < 0)
        {
            sex1 = true;
            sex2 = false;
            //animator.speed = 1;
        }

           if (Input.GetAxis("Mouse X") > 0)
           {
            sex1 = false;
            sex2 = true;
            //animator.speed = 1;
        }
        animator.SetBool("sex1", sex1);
        animator.SetBool("sex2", sex2);
    }

    void SexSound1()
    {
        //Sex1.Play();
        FindObjectOfType<AudioManager>().Play("sex1");
    }

    void SexSound2()
    {
        //Sex2.Play();
        FindObjectOfType<AudioManager>().Play("sex2");
    }

    void GiveBirth()
    {
        baby.transform.position -= new Vector3(0, .05f, 0);
    }
}
