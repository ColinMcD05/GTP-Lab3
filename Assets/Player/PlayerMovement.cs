using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] CameraBounds boundsChecker;
	public float playerSpeed = 10f;

	public void MoveHorizontal(float moveAmount)
	{
		Vector3 newPosition = transform.position + new Vector3(moveAmount, 0, 0) * playerSpeed * Time.deltaTime;
		newPosition.x = Mathf.Clamp(newPosition.x, -boundsChecker.GetHorizontalBounds(), boundsChecker.GetHorizontalBounds());

		transform.position = newPosition;
		Debug.Log(transform.position);
	}
}
