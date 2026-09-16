using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    //Player references
    [SerializeField] PlayerMovement playerMovement;

    public void Move(InputAction.CallbackContext value)
    {
        playerMovement.Move(value.ReadValue<Vector2>());
        Debug.Log("Moving");
    }
}
