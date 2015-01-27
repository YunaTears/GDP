using UnityEngine;
using System.Collections;

public class Tar : MonoBehaviour {

    public GameObject objectPUp;

    void Start()
    {
        objectPUp = GameObject.Find("PowerUp");
    }

    void OnTriggerEnter(Collider target)
    {
        if (target.CompareTag("PlayerOne"))
        {
            if (objectPUp.GetComponent<PowerUpState>().p1Protected == false)
            target.transform.root.gameObject.GetComponent<Rigidbody>().drag = 2;
            else
            {
                objectPUp.GetComponent<PowerUpState>().p1Protected = false;
                Destroy(this.gameObject);
            }
        }

        if (target.CompareTag("PlayerTwo"))
        {
            if (objectPUp.GetComponent<PowerUpState>().p2Protected == false)
                target.transform.root.gameObject.GetComponent<Rigidbody>().drag = 2;
            else
            {
                objectPUp.GetComponent<PowerUpState>().p2Protected = false;
                Destroy(this.gameObject);
            }
        }

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
