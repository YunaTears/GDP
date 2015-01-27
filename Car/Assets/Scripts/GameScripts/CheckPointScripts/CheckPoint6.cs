using UnityEngine;
using System.Collections;

public class CheckPoint6 : MonoBehaviour
{

    public GameObject CP;

    // Update is called once per frame
    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne") && CP.GetComponent<CheckPoint>().p1Current == 5)
        {
            CP.GetComponent<CheckPoint>().p1Current = 6;
        }

        if (target.CompareTag("PlayerTwo") && CP.GetComponent<CheckPoint>().p2Current == 5)
        {
            CP.GetComponent<CheckPoint>().p2Current = 6;
        }
    }
}