using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 resetPosition;
    public int maxSpeed = 10;
    
    private Rigidbody rig;

    public Collider goal1, goal2, goal3, goal4;
    public SpawnerController manager;
    public ScoreManager managerScore;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Paddle" || other.gameObject.tag == "BallSpawner" || other.gameObject.tag == "Goal")
        {
            if (rig.velocity.magnitude < maxSpeed)
            {
                Debug.Log("OK");
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == goal1)
        {
            managerScore.AddP1Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == goal2)
        {
            managerScore.AddP2Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == goal3)
        {
            managerScore.AddP3Score(1);
            manager.RemoveBall(gameObject);
        }
        if (other == goal4)
        {
            managerScore.AddP4Score(1);
            manager.RemoveBall(gameObject);
        }
    }

}
