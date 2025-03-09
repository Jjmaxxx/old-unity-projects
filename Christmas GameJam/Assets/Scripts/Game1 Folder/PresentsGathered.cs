using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentsGathered : MonoBehaviour
{
    public int PresentsGot = 0;
    public Text numberOfPresents;
    public Text numberOfPresents2;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer <= 30)
        {
            numberOfPresents.text = "Presents Gathered: " + PresentsGot.ToString();
            numberOfPresents2 = null;
        }
        else if (timer >= 30)
        {
            numberOfPresents2 = GameObject.Find("Canvas").transform.Find("numberOfPresents").GetComponent<Text>();
            numberOfPresents2.text = "Presents: " + PresentsGot.ToString();

            numberOfPresents = null;
        }
       
        //numberOfPresents2.text = "Presents: " + PresentsGot.ToString();
      

    }
}
