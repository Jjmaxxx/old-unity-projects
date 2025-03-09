using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Presents : MonoBehaviour
{
    //public int tagsRestraint = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("backdrop1").GetComponent<SpawningPresents>().limit += 1;
        }
    }
}
