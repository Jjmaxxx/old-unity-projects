using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject bomb; 
    public Vector2Int direction;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2Int(0,1);
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space")){         
            Instantiate(bomb, new Vector3(this.transform.position.x,this.transform.position.y,0), Quaternion.identity).transform.parent = gameObject.transform;
        }
        if(Input.GetKey("w")){         
            rb.MovePosition(transform.position + transform.up);
        }else if(Input.GetKey("a")){         
            rb.MovePosition(transform.position + -transform.right);
        }else if(Input.GetKey("s")){         
            rb.MovePosition(transform.position + -transform.up);
        }else if(Input.GetKey("d")){         
            rb.MovePosition(transform.position + transform.right);
        }
        if(Input.GetKey("w")){         
            direction = new Vector2Int(0,1);
        }else if(Input.GetKey("a")){         
            direction = new Vector2Int(-1,0);            
        }else if(Input.GetKey("s")){         
            direction = new Vector2Int(0,-1);
        }else if(Input.GetKey("d")){         
            direction = new Vector2Int(1,0);
        }
    }
    
}

