using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float sensitivity = 5.0f;
    public float smoothing = 2.0f;
    public GameObject player;
    Vector2 mouseLook;
    Vector2 smoothV;
    // Start is called before the first frame update
    void Start()
    {
        player = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x,md.x, 1f/smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y,md.y, 1f/smoothing);
        if(mouseLook.y + smoothV.y < 80  && mouseLook.y + smoothV.y > -80){
            mouseLook += smoothV;
        }
        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
    }
}
