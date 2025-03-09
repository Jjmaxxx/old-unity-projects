using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed = 1.0f;
    public float fuel = 300.0f;
    public float fuelDeplete = 3.1f;
    public float horizontal;
    public float vertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 target = transform.position + new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }
    void Update(){
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if(Mathf.Abs(Input.GetAxisRaw("Horizontal")) < 0.1f && Mathf.Abs(Input.GetAxisRaw("Vertical")) < 0.1f){
            fuel -= fuelDeplete;
        }
        // if(Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0){
        //     fuel -= fuelDeplete;
        // }

        // if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0){
        //     fuel -= fuelDeplete;
        // }


        if(fuel <= 0){
            SceneManager.LoadScene(0,LoadSceneMode.Single);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Finish"){
            print("goodsja000");
            this.gameObject.SetActive(false);
        }
    }

    
    
}
