using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetUI : MonoBehaviour
{

    private Planet planet;
    private Text PlanetName;
    private Text Population;
    private Text PlanetHealth;
    //order 
    private Text Happiness;
    private Text FoodSupply;


    // Start is called before the first frame update
    void Start()
    {
        planet = GetComponent<Planet>();
        //make sure the canvas is the first child gameobject of planet
        PlanetName = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>();
        Population = transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Text>();
        PlanetHealth = transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<Text>();
        Happiness = transform.GetChild(0).GetChild(0).GetChild(3).GetComponent<Text>();
        FoodSupply = transform.GetChild(0).GetChild(0).GetChild(4).GetComponent<Text>();
        
        PlanetName.text = planet.PlanetName;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Population.text = "Population: " + Mathf.Round(planet.population);
        PlanetHealth.text = "Planet Health: 0";
        Happiness.text = "Happiness: " + planet.happiness;
        FoodSupply.text = "FoodSupply: " + planet.foodSupply;
    
    }
    void OnMouseOver(){
        if(Input.GetMouseButtonDown(0)){
            if(transform.GetChild(0).gameObject.activeSelf){
                transform.GetChild(0).gameObject.SetActive(false);
            } 
            else{
                transform.GetChild(0).gameObject.SetActive(true);
            } 
        }
    }
    
}
