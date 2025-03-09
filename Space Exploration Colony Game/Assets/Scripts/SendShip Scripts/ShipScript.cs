using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public GameObject OriginalPlanet;
    public GameObject Ship;
    public GameObject destinationPlanet;
    public GameObject SpaceStation;
    public Planet Planet1;


    // Start is called before the first frame update
    void Start()
    {
        float yDist = Mathf.Abs(transform.position.y - destinationPlanet.transform.position.y);
        float hypotenuse = Mathf.Abs((transform.position - destinationPlanet.transform.position).magnitude);
        float rotation = Mathf.Asin(yDist/hypotenuse) * Mathf.Rad2Deg;
        print(rotation);
        transform.Rotate(0,0, 90.0f -  rotation);

        //transform.LookAt(destinationPlanet.transform.position,Vector3.up);
    }

    // Update is called once per frame
    void Update()
    {
        if(destinationPlanet != null){
            transform.position = Vector2.MoveTowards(Ship.transform.position, destinationPlanet.transform.position, 0.05f);
        }
    }
    public void setDestination(GameObject destPlanet){
        destinationPlanet = destPlanet;
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Planet"){
            destinationPlanet.GetComponent<Planet>().population += 1000;
            Destroy(this.gameObject);
        }
  
    }
}
