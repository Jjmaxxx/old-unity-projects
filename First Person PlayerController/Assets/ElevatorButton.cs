﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButton : Button
{
    public Elevator elevatorScript;
    public override void Press(){
        elevatorScript.activated();
    }
}
