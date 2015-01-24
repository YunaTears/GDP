using UnityEngine;
using System.Collections;

public class PowerUpState : MonoBehaviour
{
    // current power up P1 possess
    public int  p1PowerUp;
    // Does p1 have any power up currently
    public bool p1HavePowerUp;

    // current power up P1 possess
    public int  p2PowerUp;
    // Does p1 have any power up currently
    public bool p2HavePowerUp;

    void Start()
    {
        p1PowerUp = 0;
        p2PowerUp = 0;
    }

    void Update()
    {
        if (p1HavePowerUp == false)
            p1PowerUp = 0;
        if (p2HavePowerUp == false)
            p2PowerUp = 0;
    }
}