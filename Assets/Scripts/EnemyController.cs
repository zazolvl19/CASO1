using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        int enemyCount = 0;
        if (other.gameObject.tag == "Bullet")
        {
            enemyCount++;
            StateManager.Instance.setKills(enemyCount.ToString());
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}