using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Debug.DrawRay(transform.position, transform.forward * interactDistance);
            Physics.Raycast(transform.position, transform.forward, out hit, interactDistance);
            // hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 1000, ForceMode.Impulse);
            if(hit.collider.gameObject.tag == "button"){
                hit.collider.gameObject.GetComponent<Button>().Press();
            }
        }
    }
}
