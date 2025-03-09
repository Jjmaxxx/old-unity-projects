using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcefield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.5f,0,0);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Boundary"){
            Destroy(this.gameObject);
        }
        if(other.gameObject.tag == "zombie"){
            Destroy(other.gameObject);
        }
    }
}
