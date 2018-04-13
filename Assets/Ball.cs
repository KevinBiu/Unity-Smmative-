using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Rigidbody2D rb;

    public float releaseTime;

    private bool isPressed = false;

    void Update()
    {
        if (isPressed)
        {
            rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }



    void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }


    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);


        GetComponent<SpringJoint2D>().enabled = false;
    }





}

