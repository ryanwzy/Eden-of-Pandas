using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {


    [SerializeField]
    private LayerMask clickableLayer;
    Vector2 mousePos;

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit2D hitInfo = new RaycastHit2D();

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            hitInfo = Physics2D.Raycast(mousePos, Vector2.zero, clickableLayer);

            if (hitInfo.transform.name == "wear")
            { 
            hitInfo.collider.GetComponent<ClickOn>().ClickMe();
                FindObjectOfType<AudioManager>().Play("click");
            }

            if(hitInfo.transform.name == "panda3")
            {
                if(hitInfo.collider.GetComponent<Panda3Movement>().enable == true)
                hitInfo.collider.GetComponent<Panda3Movement>().consent = true;
                FindObjectOfType<AudioManager>().Play("click");
            }

            if (hitInfo.transform.name == "partner3")
            {
                hitInfo.collider.GetComponent<Partner3>().consent = true;
                FindObjectOfType<AudioManager>().Play("click");
            }

            if (hitInfo.transform.name == "partner3")
            {
                if(FindObjectOfType<Panda3Movement>().consent == true && hitInfo.collider.GetComponent<Partner3>().ReadyToTake == true)
                    hitInfo.collider.GetComponent<Partner3>().take = true;
                FindObjectOfType<AudioManager>().Play("click");
            }

            if (hitInfo.transform.name == "panda4")
            {
                hitInfo.collider.GetComponent<panda4>().beClicked = true;
                FindObjectOfType<AudioManager>().Play("click");

            }

        }
        if (Input.GetMouseButtonUp(0))
        {
            FindObjectOfType<Partner3>().consent = false;
            FindObjectOfType<panda4>().beClicked = false;
        }
    }
}
