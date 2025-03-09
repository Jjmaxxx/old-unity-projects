using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButton : Button
{
    public GameObject cube;

    public override void Press(){
        Instantiate(cube);
    }
}
