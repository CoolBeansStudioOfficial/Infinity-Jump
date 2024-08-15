using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed;
    public float jumpSpeed;

    int jumps = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumps == 1)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
                jumps--;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        jumps = 1;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        jumps = 0;
    }
}
