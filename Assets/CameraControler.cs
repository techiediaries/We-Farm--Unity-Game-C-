﻿using UnityEngine;
using System.Collections;

public class CameraControler : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = offset + player.transform.position;
	}
}
