using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 180f; // Rotation speed in degrees per second
    public float moveSpeed = 5f; // Movement speed in units per second

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Rotation
        float rotationInput = Input.GetAxis("Horizontal");
        RotatePlayer(rotationInput);

        // Movement
        float moveInput = Input.GetAxis("Vertical");
        MovePlayer(moveInput);
    }

    void RotatePlayer(float rotationInput)
    {
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.forward * rotationAmount * -1); // Invert rotation
    }

    void MovePlayer(float moveInput)
    {
        Vector2 moveDirection = new Vector2(0, moveInput).normalized;
        float moveSpeedAdjusted = moveInput > 0 ? moveSpeed : moveSpeed * 0.5f; // Adjust speed when moving backwards

        rb.velocity = transform.up * moveDirection.y * moveSpeedAdjusted;
    }
}
