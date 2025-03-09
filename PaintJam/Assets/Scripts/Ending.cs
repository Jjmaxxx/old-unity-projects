using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Text FinalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FinalScore.text = "Final Score: " + GameObject.Find("Canvas").GetComponent<CanvasScript>().score.ToString();

    }
}
