using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeMovements : MonoBehaviour
{
    public GameObject[] winBlocks;
    public GameObject[] movableBlocks;
    bool isWinning;
    public List<Vector3> coordinateList;

    void Start()
    {
        winBlocks = GameObject.FindGameObjectsWithTag("Finish");
        movableBlocks = GameObject.FindGameObjectsWithTag("Movable");
    }

    void CheckIfAllWinBlocksAreCovered()
    {
        for (int i = 0; i < winBlocks.Length; i++)
        {
            for (int j = 0; j < movableBlocks.Length; j++)
            {
                if (winBlocks[i].transform.position + new Vector3(0, 1, 0) == movableBlocks[j].transform.position)
                {
                    isWinning = true;
                }
                else
                {
                    isWinning = false;
                }
            }
        }

        if (isWinning)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        Vector3 hit = other.contacts[0].normal;
        float angle = Vector3.Angle(hit, Vector3.forward);

        if (Mathf.Approximately(angle, 0))
        {
            if (GameObject.Find($"Block {transform.position.x} {transform.position.z + 1}"))
            {
                transform.position = GameObject.Find($"Block {transform.position.x} {transform.position.z + 1}")
                    .transform.position;
                transform.position += new Vector3(0,1,0);
                coordinateList.Add(new Vector3(transform.position.x, 1, transform.position.z-1));
                other.gameObject.GetComponent<PlayerController>().lastMoved.Add(transform.name);
            }
        }

        if (Mathf.Approximately(angle, 180))
        {
            if (GameObject.Find($"Block {transform.position.x} {transform.position.z - 1}"))
            {
                transform.position = GameObject.Find($"Block {transform.position.x} {transform.position.z - 1}")
                    .transform.position;
                transform.position += new Vector3(0, 1, 0);
                coordinateList.Add(new Vector3(transform.position.x, 1, transform.position.z+1));
                other.gameObject.GetComponent<PlayerController>().lastMoved.Add(transform.name);
            }
        }

        if (Mathf.Approximately(angle, 90))
        {
            Vector3 cross = Vector3.Cross(Vector3.forward, hit);
            if (cross.y > 0)
            {
                if (GameObject.Find($"Block {transform.position.x + 1} {transform.position.z}"))
                {
                    transform.position = GameObject.Find($"Block {transform.position.x + 1} {transform.position.z}")
                        .transform.position;
                    transform.position += new Vector3(0, 1, 0);
                    coordinateList.Add(new Vector3(transform.position.x-1, 1, transform.position.z));
                    other.gameObject.GetComponent<PlayerController>().lastMoved.Add(transform.name);
                }
            }
            else
            {
                if (GameObject.Find($"Block {transform.position.x - 1} {transform.position.z}"))
                {
                    transform.position = GameObject.Find($"Block {transform.position.x - 1} {transform.position.z}")
                        .transform.position;
                    transform.position += new Vector3(0, 1, 0);
                    coordinateList.Add(new Vector3(transform.position.x+1, 1, transform.position.z));
                    other.gameObject.GetComponent<PlayerController>().lastMoved.Add(transform.name);
                }
            }
        }

        CheckIfAllWinBlocksAreCovered();
    }
}
