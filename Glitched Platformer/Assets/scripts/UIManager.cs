using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Timer;
    public Text Score;
    public float time;
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Timer.text = "Time:   " + time.ToString("f0");
        Score.text = "Score: " + points.ToString();

    }
}
