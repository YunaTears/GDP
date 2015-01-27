using UnityEngine;
using System.Collections;

public class CheckPoint1 : MonoBehaviour
{

    public GameObject CP;

    // Update is called once per frame
    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne") && CP.GetComponent<CheckPoint>().p1Current == 0)
        {
            CP.GetComponent<CheckPoint>().p1Current = 1;
        }

        if (target.CompareTag("PlayerTwo") && CP.GetComponent<CheckPoint>().p2Current == 0)
        {
            CP.GetComponent<CheckPoint>().p2Current = 1;
        }
    }
}