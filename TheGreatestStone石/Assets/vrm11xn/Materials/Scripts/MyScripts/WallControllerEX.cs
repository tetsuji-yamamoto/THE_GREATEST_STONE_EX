using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallControllerEX : MonoBehaviour
{
    public float speed = 0.05f;
    public float max_x = 10.0f;
    void Update()
    {
        this.gameObject.transform.Translate(speed, 0, 0);
        var pos = this.gameObject.transform.position;
        if (pos.x > max_x || pos.x < (-max_x)) {
            speed *= -1;
        }
    }
}
