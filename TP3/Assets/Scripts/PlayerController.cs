using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public List<string> lastMoved;

    // Update is called once per frame
    void Update()
    {
        // pour les controles je n'ai pas pu faire avec les input car je ne sais pas pourquoi cela ne fonctionnait pas
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * moveX * Time.deltaTime * 3);
        transform.Translate(Vector3.forward * moveY * Time.deltaTime * 3);
    }
}
