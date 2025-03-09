using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletManager : MonoBehaviour
{
    public GameObject bullet;
    CanvasScript canvasScript;
    public int numberOfBulletsOnScreen = 0;
    public int limitToBullets = 10;
    public int enemyTimer = 1;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {   
        StartCoroutine(raiseNumberOfBullets());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        StartCoroutine(checkChildCount());
        StartCoroutine(spawnTimer());
        numberOfBulletsOnScreen = this.transform.childCount;
    }
    public IEnumerator checkChildCount(){
        yield return new WaitForSeconds(.1f);
        numberOfBulletsOnScreen = this.transform.childCount;
    }
    public IEnumerator spawnTimer(){
        int randomNumber = Random.Range(1,5);
        yield return new WaitForSeconds(enemyTimer);
        if(numberOfBulletsOnScreen < limitToBullets){
            if(randomNumber == 1){
                Instantiate(bullet, new Vector3(Random.Range(-9,9), 6,0), Quaternion.identity).transform.parent = gameObject.transform;
            }
            if(randomNumber == 2){
                Instantiate(bullet, new Vector3(Random.Range(-9,9), -6,0), Quaternion.identity).transform.parent = gameObject.transform;
            }
            if(randomNumber == 3){
                Instantiate(bullet, new Vector3(9, Random.Range(-6,6),0), Quaternion.identity).transform.parent = gameObject.transform;
            }
            if(randomNumber == 4){
                Instantiate(bullet, new Vector3(-9, Random.Range(-6,6),0), Quaternion.identity).transform.parent = gameObject.transform;
            }
        }
    }
    public IEnumerator raiseNumberOfBullets(){
        while(true){
            yield return new WaitForSeconds(1.1f);
            limitToBullets += 1;
        }
    }

    
}
