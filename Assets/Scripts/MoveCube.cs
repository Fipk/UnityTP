using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{ 
    public float speed = 10;
    public float rotateSpeed = 10;
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        /*Vector3 movement = new Vector3(moveX, moveY, 0);

        if (movement.magnitude > 1.0)
        {
            movement = movement.normalized;
        }

        transform.Translate(movement * Time.deltaTime * speed); // move gameobject to the left
        */
        transform.Rotate(Vector3.back * moveX * Time.deltaTime * rotateSpeed);
        transform.Rotate(Vector3.right * moveY * Time.deltaTime * rotateSpeed);


    }
}
