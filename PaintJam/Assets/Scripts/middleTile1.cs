using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleTile1 : MonoBehaviour
{
    Colors colors;
    // Start is called before the first frame update
    void Start()
    {
        colors = this.gameObject.GetComponent<Colors>();
        colors.coloring = "white";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
