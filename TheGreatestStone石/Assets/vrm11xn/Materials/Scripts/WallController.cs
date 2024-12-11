using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float speed = 0.05f;
    public float max_x = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(speed, 0, 0);
        var pos = this.gameObject.transform.position;
        if (pos.x > max_x || pos.x < (-max_x))
		{
            speed *= -1;
		}
    }
}
