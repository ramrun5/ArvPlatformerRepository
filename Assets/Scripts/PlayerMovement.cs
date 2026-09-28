using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveInput;

    public Rigidbody2D rb;

    public float moveSpeed;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

    }

    public void Jump(InputAction.CallbackContext context)
    {
        rb.linearVelocity = new Vector3(0, 5, 0);
    }

    public void Update()
    {
        transform.Translate(translation: (Vector3)(moveInput * Time.deltaTime * moveSpeed));
    }
}
