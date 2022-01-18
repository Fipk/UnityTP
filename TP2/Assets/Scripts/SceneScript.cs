using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{



    public GameObject uiObject;
    public void Play()
    {
        uiObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
