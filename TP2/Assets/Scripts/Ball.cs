using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController playerScript = other.GetComponent<PlayerController>();
        playerScript.scorePlayer += 100;
        Destroy(this.gameObject);
    }
}
