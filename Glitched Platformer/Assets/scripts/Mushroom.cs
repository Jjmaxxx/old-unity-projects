using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public int randomNum;
    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(randomNum == 1)
        {
            transform.Translate(0.05f, 0, 0);
        }
        else
        {
            transform.Translate(-0.05f, 0, 0);
        }
    }
}
