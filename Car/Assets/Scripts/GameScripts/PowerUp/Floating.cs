using UnityEngine;
using System.Collections;

public class Floating : MonoBehaviour
{
    public GameObject temp;
    public float hover = 11f;

    void Start()
    {
        temp = GameObject.Find("PowerUp");
    }

    void Update()
    {
        if(temp.transform.position.y<107)
        temp.rigidbody.AddForce(Vector3.up * hover, ForceMode.Acceleration);
    }
}