using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform Player;
    public GameObject Enemy;
    public float EnemyTimer = 5.0f; 
    public int findEnemyTags = 0;

    public int numberOfEnemyTags;
    public float TeleportTimer = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //parent child functions = gppd and optimized for performance findgameobjectswithtag and getcomponent and gameobject.find big bad performance
        numberOfEnemyTags = transform.childCount; 
        if(TeleportTimer <= 0){


            for(int i = 0; i < numberOfEnemyTags; i++){
                transform.GetChild(i).GetComponent<Enemy>().teleport();
                Instantiate(Enemy,new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f)), Quaternion.identity, transform); 
            }
            TeleportTimer = 5.0f;
        } 
        EnemyTimer -= Time.deltaTime;
        TeleportTimer -= Time.deltaTime;
        if(EnemyTimer <= 0){
            EnemyTimer = 5.0f;
            Instantiate(Enemy,new Vector2(Random.Range(-7.60f,7.60f), Random.Range(-4.6f,4.6f)), Quaternion.identity,transform);
        }

    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject Enemy;
    public float teleportTimer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        teleportTimer -= Time.deltaTime;
        if(teleportTimer <= 0){
            teleportTimer = 5.0f;
        }
    }
}
*/