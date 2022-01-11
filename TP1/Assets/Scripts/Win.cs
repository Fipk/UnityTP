using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject ballPrefab;

    void OnTriggerEnter(Collider other) // yes trigger
    {
        SceneManager.LoadScene("SampleScene");
    }

    void SpawnBall()
    {
        GameObject ball = Instantiate(ballPrefab);
        ball.transform.position = GameObject.Find("RespawnZone").transform.position;
    }
}
