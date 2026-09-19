using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    //Player references
    [SerializeField] PlayerMovement playerMovement;

    private void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            playerMovement.MoveHorizontal(1);
        }

        if(Input.GetKey(KeyCode.A))
        {
            playerMovement.MoveHorizontal(-1);
        }
    }
}
