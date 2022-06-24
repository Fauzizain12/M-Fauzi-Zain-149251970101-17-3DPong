using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int P1Score, P2Score, P3Score, P4Score;
    public PaddleController P1, P2, P3, P4;

    public int maxScore = 15;

    public BallController ball;
    public GoalManager GoalM;

    public void AddP1Score(int increment)
    {
        P1Score += increment;
        if (P1Score == maxScore)
        {
            GoalM.GoalActive1();
            P1.destroyPlayer();
        }
    }

    public void AddP2Score(int increment)
    {
        P2Score += increment;
        if (P2Score == maxScore)
        {
            GoalM.GoalActive2();
            P2.destroyPlayer();
        }
    }

    public void AddP3Score(int increment)
    {
        P3Score += increment;
        Debug.Log(P3Score);
        if (P3Score == maxScore)
        {
            GoalM.GoalActive3();
            P3.destroyPlayer();
        }
    }

    public void AddP4Score(int increment)
    {
        P4Score += increment;
        if (P4Score == maxScore)
        {
            GoalM.GoalActive4();
            P4.destroyPlayer();
        }
    }
}
