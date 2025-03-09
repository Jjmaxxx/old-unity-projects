using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MarsPanel;
    public bool isMarsPanelOn = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown(){
        if(isMarsPanelOn == false){
                MarsPanel.gameObject.SetActive(true);
                isMarsPanelOn = true;
    } else if(isMarsPanelOn == true){
                MarsPanel.gameObject.SetActive(false);
                isMarsPanelOn = false;
            }      
    }
}
