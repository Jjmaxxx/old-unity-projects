using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public GameObject Sun;
    private Vector3 target = new Vector3(5.0f, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Sun.transform.position, Vector3.right, 90 * Time.deltaTime);   
    }
}
