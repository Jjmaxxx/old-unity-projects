using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentsScore : MonoBehaviour
{
    public int Score = 0;
    public Text ShowScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ShowScore.text = "PresentsScore: " + Score.ToString();
        DontDestroyOnLoad(this.gameObject);

    }
 }
