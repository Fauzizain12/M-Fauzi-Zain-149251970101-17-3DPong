using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider ball;
    public bool isP1, isP2, isP3, isP4;
    public ScoreManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            if (isP1)
            {
                manager.AddP1Score(1);
                Debug.Log("P1");
            }
            if (isP2)
            {
                manager.AddP2Score(1);
            }
            if (isP3)
            {
                manager.AddP3Score(1);
                Debug.Log("P3");
            }
            if (isP4)
            {
                manager.AddP4Score(1);
            }
        }
    }
}