using UnityEngine;
using System.Collections;

public class CheckPoint0 : MonoBehaviour
{

    public GameObject CP;

    // Update is called once per frame
    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne") && CP.GetComponent<CheckPoint>().p1Current == 7)
        {
            CP.GetComponent<CheckPoint>().p1Current = 0;
            CP.GetComponent<CheckPoint>().p1Lap ++;
        }
        if (target.CompareTag("PlayerTwo") && CP.GetComponent<CheckPoint>().p2Current == 7)
        {
            CP.GetComponent<CheckPoint>().p2Current = 0;
            CP.GetComponent<CheckPoint>().p2Lap ++;
        }


    }
}