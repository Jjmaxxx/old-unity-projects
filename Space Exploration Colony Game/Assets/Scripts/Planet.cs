﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//useful!
//[ExecuteInEditMode]
public class Planet : MonoBehaviour
{
    private PlanetRange planetRange;
    public Vector3 PlanetPosition;
    public string PlanetName;   
    public Transform PlanetPanel;
    public float airQuality;
    public int waterVolume;
    public int happiness;
    public float foodSupply;
    private float foodSurplus;
    //todo: why art thou double
    public float population;
    public float populationMortalityRate = 0.99f; 
    public int range;
    public float timer = 0;
    //public float[] seasons = new float[] { 1.0f, -0.5f, -1.0f, 0.5f };
    public float[] seasons;
    public bool isPlanetPanelOn = false;
    public Sprite PlanetSprite;
    SpriteRenderer spriteRenderer;

    private int currentSeason;
    // Start is called before the first frame update
    void Start()
    {
        planetRange = transform.GetChild(1).GetComponent<PlanetRange>();
        PlanetPosition = transform.position;
        PlanetPanel.position = PlanetPosition + new Vector3(3.4f,1.7f,0);

        //PROBLEM WAS HERE, THIS LINE OF CODE MADE THE PANEL TELEPORT A MILLION MILES AWAY
        //PlanetPanel.position = PlanetPosition - new Vector3(-300,-300,0);
        //summer,fall,winter,spring







        currentSeason = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = PlanetSprite;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed();
        happinessPercentage();
    }
    public void OnMouseDown() {
        if(isPlanetPanelOn == false){
            PlanetPanel.gameObject.SetActive(true);
                isPlanetPanelOn = true;
     } else if(isPlanetPanelOn == true){
            //idk why this is working but it's working so oh well
            //PlanetPanel.gameObject.SetActive(false);
                isPlanetPanelOn = false;
     }      
    }
    void timePassed(){
        timer += Time.deltaTime;
        if(timer>= 30.0f){
            timer = 0;
        }
        if(timer >= 22.5f){
            currentSeason = 3;
        }else if(timer >= 15.0f){
            currentSeason = 2;
        }
        else if(timer >= 7.5f){
            currentSeason = 1;
        }
        else if(timer >= 0){
            currentSeason = 0;

        }

 
        print(seasons[currentSeason]);
        foodSupply += (seasons[currentSeason] * Random.Range(-range,range));
        //1.8% is annual growth rate 1.16^4 = 1.8 roughly
        //1.16 into 7 seconds so roughly 1.023^7 = 1.16
        //so each second increase population by 1.023
        population *= 1.023f;
        //0.78% is annual mortality death rate .941^4 = .78
        //.941 into 7 second so roughly .99^7 is like pretty much around there
        //so each second decrease population by .99 
        population *= populationMortalityRate; 

    }
    void happinessPercentage(){
        //add food and water to this equation
        if(population >= 13000000000){
            happiness -= 1;
        }else if(population <= 1300000000){
            happiness += 1;
        }
        if(happiness <= 30){
            //rioting, death
            populationMortalityRate = .9f;
        }else if(happiness>= 30){
            populationMortalityRate = 0.99f;
        }
        if(happiness >= 100){
            happiness = 100;
        }
    }
    public bool isPlanetDead(){
        if(population <= 0){
            return(true);    
        }else{
            return(false);
        }
    }
}
