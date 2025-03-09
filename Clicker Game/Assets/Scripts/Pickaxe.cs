using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : MonoBehaviour
{
    Animator PickaxeSwing;
    //animators handle all animations for an object so name them something a little more general
    Vector3 mousePosition;
    Vector3 pickaxePosition;
    public Transform pickaxeObject;
    public float distance = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        PickaxeSwing = gameObject.GetComponent<Animator>();
        //unnesscary if you just set it to true by default in the animator
        //this is begging for bugs (this is bad coupling)
        //PickaxeSwing.SetBool("isPickaxeIdle", true);

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(onClick());
        movePickaxe();
    }
    IEnumerator onClick(){
        if (Input.GetMouseButton(0)){
            PickaxeSwing.SetBool("isPickaxeIdle", false);
            //use AnimationState.length to check for length of animation instead of just guessing
            //how u derive this im not sure just look in manual 
            yield return new WaitForSeconds(2);
            PickaxeSwing.SetBool("isPickaxeIdle", true);
        }
    }
    void movePickaxe(){
        //variable is somewhat unneccessary 
        mousePosition = Input.mousePosition;
        pickaxePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x + 5,mousePosition.y - 2,distance));
        pickaxeObject.position = pickaxePosition;
    }
}
