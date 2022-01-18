using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * 1.5f);

        if (transform.position.x < -7)
        {
            Destroy(this.gameObject);
        }
    }


}
