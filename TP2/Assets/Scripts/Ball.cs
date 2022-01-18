using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("coucou");
        GameObject player = GameObject.Find("Player");
        PlayerController playerScript = player.GetComponent<PlayerController>();
        playerScript.scorePlayer += 100;
        Destroy(other.gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("coucou");
        GameObject player = GameObject.Find("Player");
        PlayerController playerScript = player.GetComponent<PlayerController>();
        playerScript.scorePlayer += 100;
        Destroy(other.gameObject);
    }
}
