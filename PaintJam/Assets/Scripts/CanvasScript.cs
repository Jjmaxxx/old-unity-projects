using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
    public float timer = 60.0f;
    public int score = 0;
    public Text ScoreText;
    public Text timeShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timeShow.text = "Time Left: " + timer.ToString("f0");
        if(timer < 0){
            SceneManager.LoadScene("Win");
        }
        DontDestroyOnLoad(this.gameObject);
        ScoreText.text = "Score: " + score.ToString("f0");
    }
}
