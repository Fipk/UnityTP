using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCube : MonoBehaviour
{

    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = transform.Find("Cube").gameObject; // récupérer un child object
        Debug.Log(cube);
    }

}
