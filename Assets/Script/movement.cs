﻿using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(0, -1, 0);
        }
    }
}
