using UnityEngine;
using System.Collections;

public class UsingPowerUp : MonoBehaviour
{
    public GameObject p1Barrier;
    public GameObject objectPU;
    public Transform tarPrefab;
    public Transform magPrefab;

    void Start()
    {
        objectPU = GameObject.Find("PowerUp");
        
    }

    void Update()
    {
        if (Input.GetKeyDown("z"))
            p1Barrier.renderer.enabled = true;
        if (Input.GetKeyDown("x"))
            p1Barrier.renderer.enabled = false;
            

        if (Input.GetKeyDown("f"))
        {
            //using tar
            if (objectPU.GetComponent<PowerUpState>().p1PowerUp == 1)
            {
                //Instantiate a TAR here.
                Transform myNewInstance = (Transform)Instantiate(tarPrefab, GameObject.Find("TarSpawnPoint").transform.position, Quaternion.identity);
            }
            //using barrier
            if (objectPU.GetComponent<PowerUpState>().p1PowerUp == 2)
            {
                //Instantiate a barrier here.
                p1Barrier.GetComponent<MeshRenderer>().enabled = true;
                
            }
            //using car magnet
            if (objectPU.GetComponent<PowerUpState>().p1PowerUp == 3)
            {
                Transform myNewInstance = (Transform)Instantiate(magPrefab, GameObject.Find("MagSpawnPoint").transform.position, Quaternion.identity);
                Debug.Log("Magnet");
            }
            //using rocket
            if (objectPU.GetComponent<PowerUpState>().p1PowerUp == 4)
            {
                //Instantiate a rocket here.
                Debug.Log("Shiuuuu Boom");
            }

            if (objectPU.GetComponent<PowerUpState>().p1PowerUp != 0)
            {
                //Change p1 PowerUpState to none.
                objectPU.GetComponent<PowerUpState>().p1PowerUp = 0;
                //Player1 no longer have a power up
                objectPU.GetComponent<PowerUpState>().p1HavePowerUp = false;
            }
        }

        if (Input.GetKeyDown("l"))
        {
            //using tar
            if (objectPU.GetComponent<PowerUpState>().p2PowerUp == 1)
            {
                //Instantiate a TAR here.
                Debug.Log("TAR TAR TAR");
            }
            //using barrier
            if (objectPU.GetComponent<PowerUpState>().p2PowerUp == 2)
            {
                //Instantiate a barrier here.
                Debug.Log("wiu wiu wiu");
            }
            //using car magnet
            if (objectPU.GetComponent<PowerUpState>().p2PowerUp == 3)
            {
                //Instantiate a magnet here.
                Debug.Log("Magnet");
            }
            //using rocket
            if (objectPU.GetComponent<PowerUpState>().p2PowerUp == 4)
            {
                //Instantiate a rocket here.
                Debug.Log("Shiuuuu Boom");
            }

            //Change p1 PowerUpState to none.
            objectPU.GetComponent<PowerUpState>().p2PowerUp = 0;
            //Player1 no longer have a power up
            objectPU.GetComponent<PowerUpState>().p2HavePowerUp = false;
        }
    }
}