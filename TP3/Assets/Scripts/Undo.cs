using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Undo : MonoBehaviour
{
    private CubeMovements script;
    public void UndoAction()
    {
        PlayerController player = GameObject.Find("Player").GetComponent<PlayerController>();
        script = GameObject.Find(player.lastMoved[player.lastMoved.Count - 1]).GetComponent<CubeMovements>();
        if (script.coordinateList.Count != 0 && player.lastMoved.Count != 0)
        {
            script.transform.position = script.coordinateList[script.coordinateList.Count - 1];
            player.lastMoved.RemoveAt(player.lastMoved.Count - 1);
            script.coordinateList.RemoveAt(script.coordinateList.Count - 1);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
