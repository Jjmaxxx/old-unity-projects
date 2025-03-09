using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ExitText;

    // void Start()
    // {

    // }

    // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void OnMouseDown() {
        Application.Quit();
    }
    public void OnMouseEnter(){
        ExitText.color = Color.gray;
    }
    public void OnMouseExit() {
        ExitText.color = Color.white;
    }        
}
