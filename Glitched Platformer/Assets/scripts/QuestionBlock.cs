using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBlock : MonoBehaviour
{
    public GameObject Empty;
    public GameObject Mushroom;
    public GameObject Flower;
    public GameObject Player;
    public PlayerMove playerMove;

    // Start is called before the first frame update
    void Start()
    {
        //Player = GameObject.Find("Player");
        playerMove = Player.GetComponent<PlayerMove>();
        //Empty = Resources.Load("Prefab/empty");
        //Mushroom = Resources.Load("Prefab/mushroom");
        //Flower = Resources.Load("Prefab/flower");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.transform.parent.gameObject);
            Instantiate(Empty, new Vector3(this.transform.position.x, this.transform.position.y, 0), Quaternion.identity);
            if (playerMove.PlayerState == 0)
            {
                print("Mush");
                Instantiate(Mushroom, new Vector3(this.transform.position.x, this.transform.position.y + 1.4f, 0), Quaternion.identity);
            }
            else
            {
                print("Flowee");
                Instantiate(Flower, new Vector3(this.transform.position.x, this.transform.position.y + 1.4f, 0), Quaternion.identity);
            }
        }
    }
}
