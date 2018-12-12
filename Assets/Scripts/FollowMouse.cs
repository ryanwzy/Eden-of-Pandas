using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Vector2 mousePosition;
    private Vector2 direction;
    //public float moveSpeed = 0.1f;

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        direction = mousePosition - new Vector2(transform.position.x,transform.position.y);
        this.GetComponent<Rigidbody2D>().velocity = direction * 0.3f;
    }
}