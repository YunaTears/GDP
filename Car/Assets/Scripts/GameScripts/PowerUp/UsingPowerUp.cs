using UnityEngine;
using System.Collections;

public class UsingPowerUp : MonoBehaviour
{
    public GameObject myPowerUp;

    void Update()
    {
        //using tar
        if (myPowerUp.GetComponent<PowerUpState>().p1PowerUp == 1 && (Input.GetKeyDown("f")))
        {
            //Instantiate a TAR here.
            Debug.Log("TAR TAR TAR");

            //Change p1 PowerUpState back to none.
            myPowerUp.GetComponent<PowerUpState>().p1PowerUp = 0;
            //Player1 no longer have a power up
            myPowerUp.GetComponent<PowerUpState>().p1HavePowerUp = false;
        }
        //using barrier
        if (myPowerUp.GetComponent<PowerUpState>().p1PowerUp == 2 && (Input.GetKeyDown("f")))
        {
            //Instantiate a barrier here.
            Debug.Log("TAR TAR TAR");

            //Change p1 PowerUpState back to none.
            myPowerUp.GetComponent<PowerUpState>().p1PowerUp = 0;
            //Player1 no longer have a power up
            myPowerUp.GetComponent<PowerUpState>().p1HavePowerUp = false;
        }
        //using car magnet
        if (myPowerUp.GetComponent<PowerUpState>().p1PowerUp == 3 && (Input.GetKeyDown("f")))
        {
            //Instantiate a TAR here.
            Debug.Log("TAR TAR TAR");

            //Change p1 PowerUpState back to none.
            myPowerUp.GetComponent<PowerUpState>().p1PowerUp = 0;
            //Player1 no longer have a power up
            myPowerUp.GetComponent<PowerUpState>().p1HavePowerUp = false;
        }
        //using rocket
        if (myPowerUp.GetComponent<PowerUpState>().p1PowerUp == 4 && (Input.GetKeyDown("f")))
        {
            //Instantiate a TAR here.
            Debug.Log("TAR TAR TAR");

            //Change p1 PowerUpState back to none.
            myPowerUp.GetComponent<PowerUpState>().p1PowerUp = 0;
            //Player1 no longer have a power up
            myPowerUp.GetComponent<PowerUpState>().p1HavePowerUp = false;
        }
    }
}