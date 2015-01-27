using UnityEngine;
using System.Collections;

public class CheckPoint2 : MonoBehaviour
{

    public GameObject CP;

    // Update is called once per frame
    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne") && CP.GetComponent<CheckPoint>().p1Current == 1)
        {
            CP.GetComponent<CheckPoint>().p1Current = 2;
        }

        if (target.CompareTag("PlayerTwo") && CP.GetComponent<CheckPoint>().p2Current == 1)
        {
            CP.GetComponent<CheckPoint>().p2Current = 2;
        }
    }
}