using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;

    public float moveSpeed;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void Update()
    {
        transform.Translate(translation: (Vector3)(moveInput * Time.deltaTime * moveSpeed));
    }
}
