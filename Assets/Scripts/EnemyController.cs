using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private AIDestinationSetter destinationSetter;

    void Start()
    {
        destinationSetter = GetComponent<AIDestinationSetter>();

        GameObject targetDestination = GameObject.FindGameObjectWithTag("Player");
        destinationSetter.target = targetDestination.transform;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            StateManager.Instance.setKills(StateManager.Instance.getKills() + 1) ;
        }
    }
}