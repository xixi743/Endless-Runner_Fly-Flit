﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour {

    public GameObject obstacle;


	// Use this for initialization
	void Start () {
        Instantiate(obstacle, transform.position, Quaternion.identity);
	}
	

}
