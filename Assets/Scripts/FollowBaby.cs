using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowBaby : MonoBehaviour {

    public GameObject baby;
    private Vector2 direction;
    //public float moveSpeed = 0.1f;

    void Update()
    {

        direction = baby.transform.position - transform.position;
        this.GetComponent<Rigidbody2D>().velocity = direction;

        if (baby.transform.parent.transform.position.x >= 17.32f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
