using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject Bubble;

    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
    private void OnTriggerEnter2D(Collider2D other) {
        Vector2 position = transform.position;
        if(other.gameObject.tag == "Player"){
            Instantiate(Bubble, new Vector2(position.x,position.y - 1), Quaternion.identity);
        }
    }
}
