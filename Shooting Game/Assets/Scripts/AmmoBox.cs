using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AmmoBoxes;
    public int numberOfAmmoBoxes = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.1f,0,0);
        spawn();
    }
    void spawn(){
        if(numberOfAmmoBoxes >= 1){
            Instantiate(AmmoBoxes, new Vector2(-7,2.25f), Quaternion.identity);
        }   

        
    }

}
