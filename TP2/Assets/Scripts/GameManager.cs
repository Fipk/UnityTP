using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> goList;


    IEnumerator SpawnPlateform()
    {
        while (true)
        {
            Random.InitState((int)DateTime.Now.Ticks);
            float test = Random.Range(0, 6);
            float number = Random.Range(0.0f, 0.50f);
            GameObject platf = Instantiate(goList[(int)test]);
            platf.transform.position = new Vector2(2, number);

            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator Start()
    {
        Time.timeScale = 0;
        yield return StartCoroutine("SpawnPlateform");
    }



}
