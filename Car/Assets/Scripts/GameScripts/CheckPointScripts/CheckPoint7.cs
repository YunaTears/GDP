using UnityEngine;
using System.Collections;

public class CheckPoint7 : MonoBehaviour
{

    public GameObject CP;

    // Update is called once per frame
    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne") && CP.GetComponent<CheckPoint>().p1Current == 6)
        {
            CP.GetComponent<CheckPoint>().p1Current = 7;
        }

        if (target.CompareTag("PlayerTwo") && CP.GetComponent<CheckPoint>().p2Current == 6)
        {
            CP.GetComponent<CheckPoint>().p2Current = 7;
        }
    }
}