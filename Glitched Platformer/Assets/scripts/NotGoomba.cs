using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGoomba : MonoBehaviour
{
    public int randomNum;
    public float posMove = 0.05f;
    public float negMove = -0.05f;
    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (randomNum == 1)
        {
            transform.Translate(posMove, 0, 0);
        }
        else
        {
            transform.Translate(negMove, 0, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "floor" || other.gameObject.tag == "NotGoomba")
        {
            posMove = posMove* -1;
            negMove = negMove* -1;
        }
        if(other.gameObject.tag == "fireball")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);

        }
    }
    
}
