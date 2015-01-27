using UnityEngine;
using System.Collections;

public class CheckPoint3 : MonoBehaviour
{

    public GameObject CP;

    // Update is called once per frame
    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne") && CP.GetComponent<CheckPoint>().p1Current == 2)
        {
            CP.GetComponent<CheckPoint>().p1Current = 3;
        }

        if (target.CompareTag("PlayerTwo") && CP.GetComponent<CheckPoint>().p2Current == 2)
        {
            CP.GetComponent<CheckPoint>().p2Current = 3;
        }
    }
}