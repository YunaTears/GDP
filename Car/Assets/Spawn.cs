//////////////////////////////////////////////////////////////
// Spawn.cs
// Car spawn script
//
// © 2013 Chotepud Teo Congyu
//////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	private int car;
	private GameObject player;
	// Use this for initialization
	void Awake () 
	{
		car = 1;
		Camera.main.transform.position = transform.position;
		Camera.main.transform.rotation = transform.rotation;
		player = GameObject.Instantiate( Resources.Load("Car/Player1") as GameObject, transform.position, transform.rotation ) as GameObject;
		(Camera.main.GetComponent(typeof (SmoothFollow)) as SmoothFollow).target = player.transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		int temp = car;
		
		if(Input.GetKeyUp(KeyCode.Alpha1))
		{
			if(car != 1)
			{
				car = 1;
			}
		}
		
		else if(Input.GetKeyUp(KeyCode.Alpha2))
		{
			if(car != 2)
			{
				car = 2;
			}
		}
		
		else if(Input.GetKeyUp(KeyCode.Alpha3))
		{
			if(car != 3)
			{
				car = 3;
			}
		}
		
		if(temp != car)
		{
			GameObject.Destroy(player);
			Camera.main.transform.position = transform.position;
			Camera.main.transform.rotation = transform.rotation;
			player = GameObject.Instantiate( Resources.Load("Car/Player" + car) as GameObject, transform.position, transform.rotation ) as GameObject;
			(Camera.main.GetComponent(typeof (SmoothFollow)) as SmoothFollow).target = player.transform;
		}
	}
}
