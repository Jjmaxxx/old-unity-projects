using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    Colors playerColor;
    Colors colors;
    CanvasScript canvas;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(despawn());
        playerColor = GameObject.FindWithTag("Player").GetComponent<Colors>();
        colors = this.gameObject.GetComponent<Colors>();
        canvas = GameObject.FindWithTag("Canvas").GetComponent<CanvasScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if(playerColor.coloring == "red"){
            this.GetComponent<Renderer>().material.color = Color.red;
            colors.coloring = "red";
        }
        else if(playerColor.coloring == "yellow"){
            this.GetComponent<Renderer>().material.color = Color.yellow;
            colors.coloring = "yellow";
        }
        else if(playerColor.coloring == "blue"){
            this.GetComponent<Renderer>().material.color = Color.blue;
            colors.coloring = "blue";
        }
        else if(playerColor.coloring == "white"){
            this.GetComponent<Renderer>().material.color = Color.white;
            colors.coloring = "white";
        }
    }
    private void OnBecameInvisible() {
        Destroy(this.gameObject);    
    }
    public IEnumerator despawn(){
        yield return new WaitForSeconds(4.0f);
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "enemyBullet"){
            Colors otherColor = other.gameObject.GetComponent<Colors>();
            if(otherColor.coloring == "red" && colors.coloring == "red"){
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                canvas.score += 500;
            }else{
                Destroy(this.gameObject);
                canvas.score -= 10;
            }
            if(otherColor.coloring == "yellow" && colors.coloring == "yellow"){
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                canvas.score += 500;
            }else{
                Destroy(this.gameObject);
                canvas.score -= 10;
            }
            if(otherColor.coloring == "blue" && colors.coloring == "blue"){
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                canvas.score += 500;
            }else{
                Destroy(this.gameObject);
                canvas.score -= 10;
            }
            if(otherColor.coloring == "white" && colors.coloring == "white"){
                Destroy(this.gameObject);
                Destroy(other.gameObject);
                canvas.score += 500;
            }else{
                Destroy(this.gameObject);
                canvas.score -= 10;
            }
        }   
    }
}

