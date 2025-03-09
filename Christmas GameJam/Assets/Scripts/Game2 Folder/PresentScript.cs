using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Chimney")
        {
            GameObject.Find("PresentsDelivered").GetComponent<PresentsScore>().Score += 5000;
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Door")
        {
            GameObject.Find("PresentsDelivered").GetComponent<PresentsScore>().Score += 3000;
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Window")
        {
            GameObject.Find("PresentsDelivered").GetComponent<PresentsScore>().Score += 1000;
            Destroy(this.gameObject);

        }
    }
}
