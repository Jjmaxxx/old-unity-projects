using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBall : MonoBehaviour, IMove, ISizeable<float>
{
    public bool moving = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moving){
            transform.Translate(0.1f * Time.deltaTime,0,0);
        }
    }
    public void move(){
        moving = false;
    }
    public void size(float deltaSize){
        transform.localScale = new Vector3(1 - deltaSize,1 - deltaSize,0);
        print("yoted");
    }
}
