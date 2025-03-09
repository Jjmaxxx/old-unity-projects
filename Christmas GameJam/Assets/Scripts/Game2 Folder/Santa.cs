using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Santa : MonoBehaviour
{
    public Text TimeLeft;
    public Sprite SpriteRight;
    public Sprite SpriteLeft;
    public SpriteRenderer spriteRenderer;
    public float speed = 0.4f;
    public GameObject Present;
    public Transform player;
    public float timer = 60.0f;
    PresentsGathered presentsGathered;
    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Transform>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        presentsGathered = GameObject.Find("PresentsGathered").GetComponent<PresentsGathered>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        movement();
        TimeLeft.text = "Time Left: " + timer.ToString("f0");
    }
    void movement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed, 0);
        if (Input.GetKeyDown("space") && presentsGathered.PresentsGot > 0)
        {
            Instantiate(Present, new Vector3(player.position.x, player.position.y), transform.rotation);
            presentsGathered.PresentsGot -= 1;
        }
        else if(presentsGathered.PresentsGot <= 0 || timer <= 0)
        {
            SceneManager.LoadScene("Ending");
        }
        if (Input.GetKeyDown("a"))
        {
            spriteRenderer.sprite = SpriteLeft;
        }
        else if (Input.GetKeyDown("d"))
        {
            spriteRenderer.sprite = SpriteRight;
        }
    }
}
