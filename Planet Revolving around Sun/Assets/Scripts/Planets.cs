using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    public Sun sun;
    public Transform sunLocation;
    public int rotationDegrees;
    public Sprite[] possiblePlanets; 
    public Vector3 sunOffset;
    private SpriteRenderer planetSpriteRenderer;
    // Start is called before the first frame update

    void Start()
    {
        rotationDegrees = Random.Range(10,20);
        planetSpriteRenderer = GetComponent<SpriteRenderer>();
        planetSpriteRenderer.sprite = randomizeSprite();
        // sunOffset = new Vector3(Random.Range(2,sun.getMaxRange()),Random.Range(2,sun.getMaxRange()),0);
        // transform.position = sunOffset;
        Vector3 patchCorrection = sun.transform.localScale/2;
        // transform.position -= patchCorrection;
        //transform.localScale = randomSize();
    }

    // Update is called once per frame
    void Update()
    { 
        //it doesnt revolve around the sun's transform.position
        //transform.rotatearound is broken
        //set rotation point on sun, rotate on z axis with Vector, move by rotationDegrees * Time
        transform.RotateAround(sunLocation.transform.position, new Vector3(0,0,1), rotationDegrees * Time.deltaTime);
        transform.Rotate(0,0,Random.Range(1,4),Space.Self);

    }
    Sprite randomizeSprite(){
        return possiblePlanets[Random.Range(0,possiblePlanets.Length - 1)];
        
    }
    Vector3 randomSize(){
        float size = Random.Range(0.1f,3);
        return new Vector3(size,size,0);
    }
}
