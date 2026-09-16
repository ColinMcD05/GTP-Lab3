using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] BoundsChecker boundsChecker;
	public float playerSpeed = 10f;

	public void Move(Vector3 moveInput)
	{
		MoveHorizontal(moveInput.x);
		MoveVertical(moveInput.y);
	}

	public void MoveHorizontal(float moveAmount)
	{
		Vector3 newPosition = transform.position + new Vector3(moveAmount, 0, 0) * playerSpeed * Time.deltaTime;
		if(boundsChecker.CheckInBounds(newPosition))
		{
			transform.position = newPosition;
		}
	}

	public void MoveVertical(float moveAmount)
	{
		Vector3 newPosition = transform.position + new Vector3(0, moveAmount, 0) * playerSpeed * Time.deltaTime;
		if(boundsChecker.CheckInBounds(newPosition))
		{
			transform.position = newPosition;
		}
	}
}
