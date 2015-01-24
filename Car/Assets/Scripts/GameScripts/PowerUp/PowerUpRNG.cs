using UnityEngine;
using System.Collections;

public class PowerUpRNG : MonoBehaviour 
{
    //RNG that decides what power up
    int choosePowerUp;

   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerOne"))
            Debug.Log("WHY ISNT IT WORKING");
        if (GetComponent<PowerUpState>().p1HavePowerUp == false)
        {
            GetComponent<PowerUpState>().p1HavePowerUp = true;
            GetComponent<PowerUpState>().p1PowerUp = Random.Range(1, 5);
        }
    }
}
