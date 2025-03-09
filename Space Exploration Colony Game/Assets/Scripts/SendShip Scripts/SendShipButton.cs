using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendShipButton : MonoBehaviour
{
    //public PlanetRange PlanetRange;
    public Button ShipButton;
    public GameObject Ship;
    public Transform MainPlanet;
    //public List<GameObject> buttonsList = new List<GameObject>(); 
    //public bool hasShipBeenSent = false;
    public Transform SendShipButtonPanel;
    public GameObject destPlanet;

    private float buttonTimer = 0f;
    public bool restrictButtons = false;
   // public int numberOfPlanetsInRange;
    public GameObject newSendShipButton;
    public Transform ShowPanel;

    // Start is called before the first frame update
    void Start()
    {
        ShipButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        ShipButton.onClick.AddListener(InstantiateShip);
        buttonTimer -= Time.deltaTime;
        //numberOfPlanetsInRange = PlanetRange.planetsInRange.Count;
        //addButtonsToList();
        //print(buttonsList);
    }
    void InstantiateShip(){
        if(buttonTimer <= 0){
            GameObject ship = Instantiate(Ship, new Vector3(MainPlanet.position.x,MainPlanet.position.y,0), Quaternion.identity);
            //this is where you should set the planet destination, get this from the button
            ship.GetComponent<ShipScript>().setDestination(destPlanet);
            buttonTimer = 1.0f;
        }
    }
  //  void InstantiateButtons(){
   //     if(restrictButtons == false && numberOfPlanetsInRange >= 1){
   //         restrictButtons = true;
    //        GameObject newShipButton = Instantiate(newSendShipButton) as GameObject;
    //        newShipButton.transform.SetParent(ShowPanel.transform,false);
     //       newShipButton.transform.localPosition = new Vector3(0,-0.1f,0);
     //   }
        //else if(PlanetRange.planetsInRange.Count <= 1){
           //
    //    }
   // void addButtonsToList(){
   //     foreach(GameObject Button in GameObject.FindGameObjectsWithTag("buttonsList")){
     //       buttonsList.Add(Button);
    //        InstantiateButtons();
     //   }
    //}    
    }

