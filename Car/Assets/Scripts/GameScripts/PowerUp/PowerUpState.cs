using UnityEngine;
using System.Collections;

public class PowerUpState : MonoBehaviour
{

    // current power up P1 possess
    public int  p1PowerUp;
    // Does p1 have any power up currently
    public bool p1HavePowerUp;
    // Is p1 protected by barrier
    public bool p1Protected;

    public float p1StartTime;
    public float p1EndTime;

    // current power up P2 possess
    public int  p2PowerUp;
    // Does p2 have any power up currently
    public bool p2HavePowerUp;
    // Is p2 protected by barrier
    public bool p2Protected;

    public float p2StartTime;
    public float p2EndTime;

    public float currentTime;
    public float barrierDuration;

    void Start()
    {
        p1PowerUp = 0;
        p1HavePowerUp = false;
        p1Protected = false;
        p1StartTime = 0.0f;
        p1EndTime = 0.0f;

        p2PowerUp = 0;
        p2HavePowerUp = false;
        p2Protected = false;
        p2StartTime = 0.0f;
        p2EndTime = 0.0f;

        currentTime = 0.0f;
        barrierDuration = 7.0f;
    }

    void Update()
    {

        if(p1Protected == true)
        {
            p1EndTime = p1StartTime + barrierDuration;
            if (p1EndTime <= currentTime)
            {
                p1Protected = false;
            }
        }
        if (p1Protected == false)
        {
            p1StartTime = Time.time;
        }

        currentTime = Time.time;
    }

}