using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActionPointsManager : MonoBehaviour
{
    public int rock, paper, scissors, hp, actionPoints;
    public int turnNumber;
    public int pointsGainedPerTurn = 2;

    public bool turnEnded = false;
    public bool pointsAlocated = true;

    private void Start()
    {
        actionPoints = pointsGainedPerTurn;
    }



}
