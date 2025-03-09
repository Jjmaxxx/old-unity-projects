using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubeScript : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCubes());
        //there is a StopCoroutine() function and a StopAllCoroutine() function running in the class
    }

    public IEnumerator spawnCubes(){
        for(int i = 0; i<100; i++){
            yield return new WaitForSeconds(0.5f);
            Instantiate(cube);
        }
    }
}
