using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unfillledTile : MonoBehaviour
{
    public int pickNumber;
    Colors colors;
    // Start is called before the first frame update
    void Start()
    {
        changeColor();
        colors = this.gameObject.GetComponent<Colors>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // void changeColor(){
    //     pickNumber = Random.Range(1,5);
    //     if(pickNumber == 1){
    //         this.GetComponent<Renderer>().material.color = Color.red;       
    //         colors.coloring = "red";   
    //     }
    //     else if(pickNumber == 2){
    //         this.GetComponent<Renderer>().material.color = Color.yellow;       
    //         colors.coloring = "yellow";
    //     }
    //     else if(pickNumber == 3){
    //         this.GetComponent<Renderer>().material.color = Color.blue;       
    //         colors.coloring = "blue";
    //     }
    //     else{
    //         this.GetComponent<Renderer>().material.color = Color.white;       
    //         colors.coloring = "white";
    //     }
    // }

    void changeColor(){
        pickNumber = Random.Range(1,5);
        // if(pickNumber == 1){
        //     this.GetComponent<Renderer>().material.color = Color.red;       
        //     this.gameObject.GetComponent<Colors>().coloring = "red";   
        // }
        // else if(pickNumber == 2){
        //     this.GetComponent<Renderer>().material.color = Color.yellow;       
        //     this.gameObject.GetComponent<Colors>().coloring = "yellow";
        // }
        // else if(pickNumber == 3){
        //     this.GetComponent<Renderer>().material.color = Color.blue;       
        //     this.gameObject.GetComponent<Colors>().coloring = "blue";
        // }
        // else{
        //     this.GetComponent<Renderer>().material.color = Color.white;       
        //     this.gameObject.GetComponent<Colors>().coloring = "white";
        // }
        switch(pickNumber){
            case 1:
                this.GetComponent<Renderer>().material.color = Color.red;
                this.gameObject.GetComponent<Colors>().coloring = "red";
                break;
            case 2:
                this.GetComponent<Renderer>().material.color = Color.yellow;       
                this.gameObject.GetComponent<Colors>().coloring = "yellow";
                break;
            case 3:
                this.GetComponent<Renderer>().material.color = Color.blue;       
                this.gameObject.GetComponent<Colors>().coloring = "blue";
                break;
            default:
                this.GetComponent<Renderer>().material.color = Color.white;       
                this.gameObject.GetComponent<Colors>().coloring = "white";
                break;
            }
        }
    }
