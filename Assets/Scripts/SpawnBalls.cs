using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }

    void SpawnBall()
    {
        GameObject ball = Instantiate(ballPrefab);
        ball.transform.position = GameObject.Find("RespawnZone").transform.position;
    }
}
