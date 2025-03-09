using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class SpawningPresents : MonoBehaviour
{
    public float timer = 30.0f;
    public Text countDown;
    public GameObject Present;
    public int limit = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        presentSpawn();
        timerDown();

    }
    void presentSpawn()
    {
        if (GameObject.FindGameObjectsWithTag("presents").Length < limit)
        {
            Instantiate(Present, new Vector2(Random.Range(-9.0f, 9.0f), 6.0f), Quaternion.identity);
        }
        if(limit >= 20)
        {
            limit = 20;
        }
    }
    void timerDown()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene("Instructions2");
        }
        countDown.text = "Timer: " + timer.ToString("f0");
    }
}
