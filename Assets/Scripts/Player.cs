using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 speed;
    public float jumpForce = 400;
    public Rigidbody2D body2d;

    Vector2 currentSpeed;
    bool isGrounded = false;

    public void PlayerInput_Move(InputAction.CallbackContext callback)
    {
        Vector2 input = callback.ReadValue<Vector2>();

        currentSpeed = new Vector2(input.x * speed.x , 0);
    }
    public void PlayerInput_Jump(InputAction.CallbackContext callback)
    {
        if (callback.performed)
        {
            if (isGrounded)
            {
                body2d.AddForce(new Vector2(0, jumpForce));
            }
        }
    }
    public void SetGrounded(bool _isGrounded)
    {
        isGrounded = _isGrounded;
    }
    private void FixedUpdate()
    {
        body2d.linearVelocityX = currentSpeed.x;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }


}
