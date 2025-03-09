using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBossMine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(despawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator despawn(){
        yield return new WaitForSeconds(10.0f);
        Destroy(this.gameObject);
    }
}
