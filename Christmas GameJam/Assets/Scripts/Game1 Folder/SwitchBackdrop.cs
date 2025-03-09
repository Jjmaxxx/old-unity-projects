using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBackdrop : MonoBehaviour
{
    public Sprite Lightest;
    public Sprite Darker;
    public Sprite Darkest;
    public SpriteRenderer spriteRenderer;
    public float timer = 30.0f;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 30)
        {
            spriteRenderer.sprite = Lightest;
        } 
        else if(timer <= 20)
        {
            spriteRenderer.sprite = Darker;
        }
        else if (timer <= 10)
        {
            spriteRenderer.sprite = Darkest;
        }
    }
}
