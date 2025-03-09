using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningHouses : MonoBehaviour
{
    public int random;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        random = Random.Range(0, 3);
        if (GameObject.FindGameObjectsWithTag("House").Length < 6)
        {
            if (random == 0)
            {
                Instantiate(Resources.Load("House#1"), new Vector2(10.0f, -0.78f), Quaternion.identity);
                random = 1;

            }
            else if (random == 1)
            {
                Instantiate(Resources.Load("House#2"), new Vector2(15.0f, -0.78f), Quaternion.identity);
                random = 2;
            }
            else
            {
                Instantiate(Resources.Load("House#3"), new Vector2(20.0f, -0.78f), Quaternion.identity);
                random = 0;
            }
        }
    }
}
