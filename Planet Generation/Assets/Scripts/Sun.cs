using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float sunRotate;
    // Start is called before the first frame update
    void Start()
    {
        float num = Random.Range(-0.5f, 0.5f);
        transform.localScale += new Vector3(num, num, num);               
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, sunRotate * Time.deltaTime, 0, Space.Self);
    }
}
