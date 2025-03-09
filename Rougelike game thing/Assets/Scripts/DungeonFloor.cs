using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonFloor : MonoBehaviour
{
    public GameObject room;
    public int numberOfRooms;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<numberOfRooms; i++){
            Instantiate(room, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
