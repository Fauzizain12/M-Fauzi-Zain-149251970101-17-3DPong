using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreP1, scoreP2, scoreP3, scoreP4;
    public ScoreManager manager;

    private void Update()
    {
        scoreP1.text = manager.P1Score.ToString();
        scoreP2.text = manager.P2Score.ToString();
        scoreP3.text = manager.P3Score.ToString();
        scoreP4.text = manager.P4Score.ToString();
    }
}
