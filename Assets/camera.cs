﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    public Transform player;
    // Use this for initialization
    Vector3 offset;
	void Start () {
		offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
	}
}
