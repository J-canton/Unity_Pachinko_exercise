using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalBalls;

    void Start()
    {
        totalBalls = 0;   
    }


    void CountAllTheBallsInTheBox()
    {
        totalBalls++;
    }
}
