using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour
{

    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne"))
            target.transform.root.gameObject.GetComponent<Rigidbody>().drag = 8;

        if (target.CompareTag("PlayerTwo"))
            target.transform.root.gameObject.GetComponent<Rigidbody>().drag = 8;

    }
    void OnTriggerExit(Collider target)
    {
        if (target.tag == "PlayerOne")
        {
            Destroy(this.gameObject);
            target.transform.root.gameObject.GetComponent<Rigidbody>().drag = 0;
        }

        if (target.tag == "PlayerTwo")
        {
            Destroy(this.gameObject);
            target.transform.root.gameObject.GetComponent<Rigidbody>().drag = 0;
        }
    }
}