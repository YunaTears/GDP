﻿using UnityEngine;
using System.Collections;

public class BarrierRotate : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.right * Time.deltaTime *2);
        transform.Rotate(Vector3.up * Time.deltaTime * 80, Space.World);
	}
}
