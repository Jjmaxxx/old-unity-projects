using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public GameObject floorTile;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(floorTile,transform);
    }


}
