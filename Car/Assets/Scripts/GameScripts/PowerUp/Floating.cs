using UnityEngine;
using System.Collections;

public class Floating : MonoBehaviour
{
    public GameObject temp;
    public float hover = 13f;
    public float maxHoverHeight = 108.0f;

    void Start()
    {
        temp = GameObject.Find("PowerUp");
    }

    void Update()
    {
        if(temp.transform.position.y<maxHoverHeight)
        temp.rigidbody.AddForce(Vector3.up * hover, ForceMode.Acceleration);
    }
}