﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightOnTouch : MonoBehaviour {

    public GameObject shadow;
    Ray ray;
    RaycastHit hit;
    
    public void LightOn()
    {
        shadow.SetActive(true);
    }
    public void lightOff()
    {
        shadow.SetActive(false);
    }
}
