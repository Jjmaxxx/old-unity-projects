using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public GameObject Floor;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.1f,0,0);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "floorBorder"){
            //store this position as a public field(Vector2)
            Instantiate(Floor, new Vector2(35.0f,-6.77f),Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
