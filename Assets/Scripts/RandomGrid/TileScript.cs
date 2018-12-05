using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour {

    public Material grass, forest, rock;
    public int type = -1; //-1 = base  0 = grass  1 = forest  2 = rock
    public TileScript left, down, up, right;
    public int tileNumber;

    Ray downRay;
    Ray leftRay;
    RaycastHit hit;

    void Start()
    {
        downRay.origin = transform.position;
        leftRay.origin = transform.position;
        downRay.direction = Vector3.forward * -3;
        leftRay.direction = Vector3.right * -3;
        
        if (Physics.Raycast(downRay, out hit))
        {
            TileScript downScript = hit.collider.GetComponent<TileScript>();
            if (downScript != null)
            {
                down = downScript;
                downScript.up = this;
            }
        }
        
        if (Physics.Raycast(leftRay, out hit))
        {
            TileScript leftScript = hit.collider.GetComponent<TileScript>();
            if (leftScript != null)
            {
                left = leftScript;
                leftScript.right = this;
            }
        }


        MatChange(type);
    }

    public void MatChange(int _type)
    {
        if (_type == 0)
        {
            GetComponent<Renderer>().material = grass;
        }
        if (_type == 1)
        {
            GetComponent<Renderer>().material = forest;
        }
        if (_type == 2)
        {
            GetComponent<Renderer>().material = rock;
        }
    }
}
