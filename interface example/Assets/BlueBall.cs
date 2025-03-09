using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : MonoBehaviour, IMove, ISizeable<int>
{
    public bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moving){
            transform.Translate(-1.0f * Time.deltaTime,0,0);
        }
    }
    public void move(){
        moving = true;
    }
    public void size(int deltaSize){
        transform.localScale = new Vector3(1 + deltaSize, 1 + deltaSize, 0);
        print("yeeted");
    }
}
