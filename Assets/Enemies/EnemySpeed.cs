using UnityEngine;

public class EnemySpeed : MonoBehaviour
{
    [SerializeField] private EnemyManager enemyManager;

    // Uses the distance from the player to the enemy to determine how fast the enemy should be
    [SerializeField] private Transform player;
    [SerializeField] private float speedMulti = 2f;

    void Update()
    {
        if (player)
        {
            // Distance calculation
            Vector3 offset = player.position - transform.position;
            float sqrLen = offset.sqrMagnitude;

            // Speed calculation
            enemyManager.enemySpeed = sqrLen * speedMulti;

            // For testing
            print(enemyManager.enemySpeed);
        }
    }
}
