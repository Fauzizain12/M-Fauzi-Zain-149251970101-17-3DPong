using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Goal1, Goal2, Goal3, Goal4;

    bool P1 = true, P2 = true, P3 = true, P4 = true;

    public int playerCounter;

    private void Update()
    {
        if (playerCounter == 3)
        {
            if (P1)
            {
                Debug.Log("P1 Win");
                StaticWinner.Winner = "P1 WIN !!";
                SceneManager.LoadScene("GameOver");
            }
            if (P2)
            {
                Debug.Log("P2 Win");
                StaticWinner.Winner = "P2 WIN !!";
                SceneManager.LoadScene("GameOver");
            }
            if (P3)
            {
                Debug.Log("P3 Win");
                StaticWinner.Winner = "P3 WIN !!";
                SceneManager.LoadScene("GameOver");
            }
            if (P4)
            {
                Debug.Log("P4 Win");
                StaticWinner.Winner = "P4 WIN !!";
                SceneManager.LoadScene("GameOver");
            }
            
        }
    }

    public void GoalActive1()
    {
        Goal1.GetComponent<MeshRenderer>().enabled = true;
        Goal1.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P1 = false;
    }

    public void GoalActive2()
    {
        Goal2.GetComponent<MeshRenderer>().enabled = true;
        Goal2.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P2 = false;
    }

    public void GoalActive3()
    {
        Goal3.GetComponent<MeshRenderer>().enabled = true;
        Goal3.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P3 = false;
    }

    public void GoalActive4()
    {
        Goal4.GetComponent<MeshRenderer>().enabled = true;
        Goal4.GetComponent<Collider>().isTrigger = false;
        playerCounter += 1;
        P4 = false;
    }
}
