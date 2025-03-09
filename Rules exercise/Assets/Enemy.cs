using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    public Vector2 randomPosition;
    public float teleportTimer = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Player = transform.parent.GetComponent<EnemyManager>().Player;
        randomPosition =  new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f));
    }

    // Update is called once per frame
    void Update()
    {
        teleportTimer -= Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position,randomPosition, 3.0f * Time.deltaTime);
        // if(teleportTimer <= 0){
        //     transform.position = new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f));
        //     teleportTimer = 5.0f;
        // }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(other.gameObject);
        }    
        if(other.gameObject.tag == "Enemy"){
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    public void teleport(){
        transform.position = new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f));

    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public Vector2 PlayerPosition;
    public Vector2 randomPosition;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        randomPosition = new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f));
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = new Vector2(Player.transform.position.x,Player.transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position,randomPosition, 3.0f * Time.deltaTime);
        if(GameObject.Find("EnemyManager").GetComponent<EnemyManager>().teleportTimer <= 0){
            transform.position = new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f));
            randomPosition = new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f));
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(other.gameObject);
        }    
        if(other.gameObject.tag == "Enemy"){
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}

*/
