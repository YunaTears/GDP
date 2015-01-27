using UnityEngine;
using System.Collections;

public class PowerUpRNG : MonoBehaviour 
{
    //RNG that decides what power up
    int choosePowerUp;

   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
        if (GetComponent<PowerUpState>().p1HavePowerUp == false)
        {
            GetComponent<PowerUpState>().p1PowerUp = Random.Range(1, 5);
            Debug.Log("p1 Recieved power up" + GetComponent<PowerUpState>().p1PowerUp);
            GetComponent<PowerUpState>().p1HavePowerUp = true;
        }

        if (other.CompareTag("PlayerTwo"))
        if (GetComponent<PowerUpState>().p2HavePowerUp == false)
        {
             GetComponent<PowerUpState>().p2PowerUp = Random.Range(1, 5);
             GetComponent<PowerUpState>().p2HavePowerUp = true;
        }
    }
}
