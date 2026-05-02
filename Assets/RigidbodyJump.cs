using UnityEngine;

public class RigidbodyJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public bool isGrounded;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Detect Jump Input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Apply upward force instantly
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // Simple ground detection
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}