using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridGenerator : MonoBehaviour {

    public int width;
    public int depth;

    public GameObject gridHolder;

    [SerializeField]
    GameObject tile;

    [SerializeField]
    GameObject TerrainHolder;

    public Text widthText, depthText;

    void Start()
    {
        Create();
        widthText.text = "Width : " + width;
        depthText.text = "Depth : " + depth;
    }

    public void Create()
    {
        if (gridHolder != null)
        {
            Destroy(gridHolder);
        }
        gridHolder = Instantiate(TerrainHolder);
        gridHolder.transform.position = new Vector3(0, 0, 0);

        int tileNum = 1;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < depth; j++)
            {
                GameObject thisTile = Instantiate(tile);
                thisTile.transform.position = new Vector3(i * 2, 0, j * 2);
                thisTile.transform.parent = gridHolder.transform;
                thisTile.GetComponent<TileScript>().type = Random.Range(0, 3);
                thisTile.GetComponent<TileScript>().tileNumber = tileNum;
                tileNum++;
            }
        }
    }


    //button scripts
    public void WidthUp()
    {
        width++;
        widthText.text = "Width : " + width;
    }
    public void WidthDown()
    {
        width--;
        widthText.text = "Width : " + width;
    }
    public void DepthUp()
    {
        depth++;
        depthText.text = "Depth : " + depth;
    }
    public void DepthDown()
    {
        depth--;
        depthText.text = "Depth : " + depth;
    }
}
