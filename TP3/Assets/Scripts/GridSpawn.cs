using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawn : MonoBehaviour
{
    public GameObject blockPrefab;
    public GameObject winPrefab;
    public GameObject wallPrefab;
    public GameObject playerPrefab;
    public GameObject movablePrefab;
    void Start()
    {
        for (int x = 0; x < 15; x++)
        {
            for (int z = 0; z < 15; z++)
            {
                if ((x == 4 && z == 6) || (x == 8 && z == 12))
                {
                    GameObject win = Instantiate(winPrefab);
                    win.transform.position = new Vector3(x, 0, z);
                    win.name = $"Block {x} {z}";
                    win.tag = "Finish";
                }
                else if (x < 1 || x > 13 || z < 1 || z > 13)
                {
                    GameObject wall = Instantiate(wallPrefab);
                    wall.transform.position = new Vector3(x, 1, z);
                    wall.name = $"Wall {x} {z}";
                }
                else
                {
                    GameObject block = Instantiate(blockPrefab);
                    block.transform.position = new Vector3(x, 0, z);
                    block.name = $"Block {x} {z}";
                }
            }
        }

        GameObject player = Instantiate(playerPrefab);
        player.transform.position = new Vector3(2, 0.5f, 2);
        player.name = "Player";

        GameObject movable = Instantiate(movablePrefab);
        movable.transform.position = new Vector3(6, 1, 3);
        movable.name = "Movable1";
        movable.tag = "Movable";

        GameObject test = Instantiate(movablePrefab);
        test.transform.position = new Vector3(11, 1, 5);
        test.name = "Movable2";
        test.tag = "Movable";
    }
}
