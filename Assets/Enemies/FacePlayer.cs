using System.Runtime.CompilerServices;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        // Get the difference in positions
        Vector3 dir = player.position - transform.position;

        // Normalize current Z direction
        dir.z = 0;
        dir.Normalize();

        // Get the dot
        float dot = Vector3.Dot(Vector3.right, dir);

        // Get the angle with arc cosine
        float angle = Mathf.Acos(dot) * Mathf.Rad2Deg;

        // Find if player is to the left or right enemy
        float cross = Vector3.Cross(Vector3.right, dir).z;

        // If player is left, make the angle negative
        if (cross < 0)
        {
            angle = -angle;
        }

        // Rotates the enemy
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, angle);
    }
}
