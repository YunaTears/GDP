using UnityEngine;
using System.Collections;

public class CheckPoint : MonoBehaviour {

    public int p1Current;
    public int p2Current;
    public int p1Lap;
    public int p2Lap;

	// Use this for initialization
	void Start () {
        p1Current = 7;
        p2Current = 7;
        p1Lap = 0;
        p2Lap = 0;

	}

    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            Debug.Log("p1Current is " + p1Current);
            Debug.Log("p1Lap is " + p1Lap);
        }
    }
}
