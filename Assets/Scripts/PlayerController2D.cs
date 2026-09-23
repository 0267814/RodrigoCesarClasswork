using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class PlayerController2D : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float jumpForce = 12f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private ContactFilter2D groundFilter;
    private Vector2 spawnPosition;
    private float horizontalInput;
    private bool jumpRequested;
    private bool hasWon;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnPosition = rb.position;
        groundFilter = new ContactFilter2D { useTriggers = false };
        groundFilter.SetLayerMask(groundLayer);
        // Only upward-facing contacts count as ground, never the side of a block.
        groundFilter.SetNormalAngle(45f, 135f);
    }

    private void Update()
    {
        if (hasWon)
            return;

        horizontalInput = Input.GetAxisRaw("Horizontal");
        jumpRequested |= Input.GetButtonDown("Jump");
    }

    private void FixedUpdate()
    {
        if (hasWon)
            return;

        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);

        if (jumpRequested && rb.linearVelocity.y <= 0.1f && rb.IsTouching(groundFilter))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        jumpRequested = false;

        // Allow another attempt if the player falls off the level.
        if (rb.position.y < -12f)
        {
            rb.position = spawnPosition;
            rb.linearVelocity = Vector2.zero;
        }
    }

    public void CompleteLevel()
    {
        hasWon = true;
        horizontalInput = 0f;
        jumpRequested = false;
        rb.linearVelocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }
}
