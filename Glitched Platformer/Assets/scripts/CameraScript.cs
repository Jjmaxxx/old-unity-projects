﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position - new Vector3(-4.01f,-2.5f,10.0f);
        if (player == null)
        {
            player = GameObject.Find("BigPlayer(Clone)");
        }
    }
}
