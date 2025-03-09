using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Rock : MonoBehaviour
{
    SpriteRenderer RockBoi;
    //absolutely should be an array
    public Sprite RockDamaged1;
    public Sprite RockDamaged2;
    public Sprite RockDamaged3;
    public Sprite RockDamaged4;
    public Sprite RockDestroyed;
    public int numberOfClicks = 0;
    public float timer = 0.3f;
    //buffer not timer
    public Text Score;
    public int Points = 0;


    // Start is called before the first frame update
    void Start()
    {
        RockBoi = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        OnMouseOver();
        timer -= Time.deltaTime;
        Score.text = "Score: " + Points.ToString();

    }    
    void OnMouseOver() {
        if(Input.GetMouseButton(0) && timer <= 0){
            numberOfClicks++;
            timer = 0.3f;
            Points++;
        }

        //you probably dont need to check for mouse input here
        //look up switch statements or use an array
        if(Input.GetMouseButton(0) && numberOfClicks >= 30){
            RockBoi.sprite = RockDamaged1;
        }
        if(Input.GetMouseButton(0) && numberOfClicks >= 60){
            RockBoi.sprite = RockDamaged2;
        }
        if(Input.GetMouseButton(0) && numberOfClicks >= 90){
            RockBoi.sprite = RockDamaged3;
        }
        if(Input.GetMouseButton(0) && numberOfClicks >= 120){
            RockBoi.sprite = RockDamaged4;
        }
        if(Input.GetMouseButton(0) && numberOfClicks >= 150){
            RockBoi.sprite = RockDestroyed;
        }         
        if(Input.GetMouseButton(0) && numberOfClicks >= 200){
            numberOfClicks = 0;
        }                                          
    }

}
