using UnityEngine;
using System.Collections;

public class CheckPoint5 : MonoBehaviour
{

    public GameObject CP;

    // Update is called once per frame
    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne") && CP.GetComponent<CheckPoint>().p1Current == 4)
        {
            CP.GetComponent<CheckPoint>().p1Current = 5;
        }

        if (target.CompareTag("PlayerTwo") && CP.GetComponent<CheckPoint>().p2Current == 4)
        {
            CP.GetComponent<CheckPoint>().p2Current = 5;
        }
    }
}