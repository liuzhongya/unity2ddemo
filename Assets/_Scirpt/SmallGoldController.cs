﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallGoldController : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, 3);
    }
}

