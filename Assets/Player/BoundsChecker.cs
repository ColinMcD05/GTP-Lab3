using UnityEngine;

public class BoundsChecker : MonoBehaviour
{
    [SerializeField] private Camera thisCamera;
    private float horizontalBounds = 4.5f;
    private float verticalBounds = 9f;

    public bool CheckInBounds(Vector3 newPosition)
    {
        if(newPosition.x > horizontalBounds || newPosition.x < -horizontalBounds
        || newPosition.y > verticalBounds || newPosition.y < -verticalBounds)
        {
            Debug.Log("Stop");
            return false;
        }
        return true;
    }
}
