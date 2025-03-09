using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public int height,width,minHeight,minWidth,maxHeight,maxWidth;
    public GameObject[,] roomArray;
    public GameObject cell;

    // Start is called before the first frame update
    void Start()
    {
        height = Random.Range(minHeight,maxHeight);
        width = Random.Range(minWidth,maxWidth);
        roomArray = new GameObject[height,width];

        for(int y=0;y<height;y++){
            for(int x=0;x<width;x++){
                roomArray[y,x] = Instantiate(cell, new Vector3(x,height - y,0), Quaternion.identity, transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
