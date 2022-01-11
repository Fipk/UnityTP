using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBodies : MonoBehaviour
{
    public GameObject ballPrefab;

    void OnTriggerEnter(Collider other) // yes trigger
    {
        Destroy(other.gameObject);
        GameObject.Find("RealGround").transform.rotation = Quaternion.identity;
        SpawnBall();
    }

    void SpawnBall()
    {
        GameObject ball = Instantiate(ballPrefab);
        ball.transform.position = GameObject.Find("RespawnZone").transform.position;
    }

    //void OnCollisionEnter(Collision other) // no trigger
    //{
    //  Debug.Log(other.gameObject);
    //}
}
