using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Text StartText;
    public BoxCollider2D boxCollider;
    public Vector3 Textposition;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        boxCollider.offset = Textposition;
    }
    public void OnMouseDown() {
        SceneManager.LoadScene("The Game",LoadSceneMode.Single);
    }
    public void OnMouseEnter(){
        StartText.color = Color.gray;
    }
    public void OnMouseExit() {
        StartText.color = Color.white;
    }
}
