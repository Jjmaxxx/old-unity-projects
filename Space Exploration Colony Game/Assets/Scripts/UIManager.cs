using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UIManager : MonoBehaviour
{
    public Planet[] planets;
    public GameObject[] planetPanels;
    public int years = 0;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ifClicked();
        yearsPassed();

    }
    // void ifClicked(){     
    //     if(Input.GetMouseButtonDown(0)){
    //         //defining mouse position on screen and tracking where it is
    //         Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //         Vector2 mousePosIn2D = new Vector2(mousePos.x, mousePos.y);
    //         //raycasting invis line from origin to mouseposition
    //         RaycastHit2D hit = Physics2D.Raycast(mousePosIn2D, Vector2.zero);            
    //         //if mouse comes into contact with a collider with tag earth return true back to RaycastHit2D 
    //         if(hit.collider != null){
    //             if(hit.collider.tag == "Earth" && isEarthPanelOn == false){
    //                 EarthPanel.gameObject.SetActive(true);
    //                 isEarthPanelOn = true;
    //         } else if(hit.collider.tag == "Earth" && isEarthPanelOn == true){
    //                 EarthPanel.gameObject.SetActive(false);
    //                 isEarthPanelOn = false;
    //         } 
    //             if(hit.collider.tag == "Mars" && isMarsPanelOn == false){
    //                 MarsPanel.gameObject.SetActive(true);
    //                 isMarsPanelOn = true;
    //         } else if(hit.collider.tag == "Mars" && isMarsPanelOn == true){
    //                 MarsPanel.gameObject.SetActive(false);
    //                 isMarsPanelOn = false;
    //         }                                   
    //     }           
    // }
    // }
    void yearsPassed(){
        timer += Time.deltaTime;
        if(timer >= 30.0f){
            timer = 0;
            years += 1;
        }
        // numberOfYears.text = "Years: " + years.ToString();
    }


}