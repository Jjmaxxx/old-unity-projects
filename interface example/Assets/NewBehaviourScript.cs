using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime,Input.GetAxis("Vertical") * Time.deltaTime,0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        // //no interface; bad code
        // if(other.gameObject.GetComponent<redBall>() != null){
        //     other.gameObject.GetComponent<redBall>().move();
        // }
        // else if(other.gameObject.GetComponent<BlueBall>() != null){
        //     other.gameObject.GetComponent<BlueBall>().move();
        // }  

        if(other.gameObject.GetComponent<IMove>() != null){
            other.gameObject.GetComponent<IMove>().move();
        }
        if(other.gameObject.GetComponent<ISizeable<int>>() != null){
            other.gameObject.GetComponent<ISizeable<int>>().size(1);
        }
        if(other.gameObject.GetComponent<ISizeable<float>>() != null){
            other.gameObject.GetComponent<ISizeable<float>>().size(1);
        }        
    }
}
