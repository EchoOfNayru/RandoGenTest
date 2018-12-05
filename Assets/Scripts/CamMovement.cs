using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {

    public float speed;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (x > 0)
        {
            transform.position = new Vector3(transform.position.x + (speed / 10), transform.position.y, transform.position.z);
        }
        else if (x < 0)
        {
            transform.position = new Vector3(transform.position.x - (speed / 10), transform.position.y, transform.position.z);
        }
        if (y > 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (speed / 10));
        }
        else if (y < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (speed / 10));
        }
    }
}
