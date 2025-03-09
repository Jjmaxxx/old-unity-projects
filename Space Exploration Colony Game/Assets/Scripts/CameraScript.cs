using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera zoom;
    public Transform cameraPosition;
    public Vector3 originalPosition;
    void Start()
    {
        originalPosition = new Vector3(this.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        //GetAxis returns floats so compare it to 0 
        if(Input.GetAxis("Mouse ScrollWheel") > 0f){
            zoom.orthographicSize--;
        }else if(Input.GetAxis("Mouse ScrollWheel") < 0f){
            zoom.orthographicSize++;
        }
        if(Input.GetKey(KeyCode.Mouse2)){
            zoom.orthographicSize = 7;
            cameraPosition.transform.position = originalPosition;
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(horizontal,vertical,0);                     
    }
}
