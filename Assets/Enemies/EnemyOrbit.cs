using Unity.VisualScripting;
using UnityEngine;

public class EnemyOrbit : MonoBehaviour
{
    //References
    [SerializeField] private Transform player;
    [SerializeField] EnemySpeed enemySpeed;

    public void Update()
    {
        if(player)
        {
            //Calculate Distance
            Vector3 offSet = transform.position - player.position;
            offSet.z = 0;
            float distance = offSet.magnitude;

            //Calculate angle
            float angle = Mathf.Atan2(offSet.y, offSet.x);

            //Convert speed to radians
            float speed = enemySpeed.speed * Mathf.Deg2Rad;

            //Increase angle for movement
            angle += speed * Time.deltaTime;

            //Finds the new position of the enemy
            Vector3 newPosition = new Vector3(Mathf.Cos(angle) * distance, Mathf.Sin(angle) * distance, 0);

            //Sets new position
            transform.position = player.position + newPosition;
        }
    }
}
