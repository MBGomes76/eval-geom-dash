using System.Collections;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public SpriteRenderer SpritePlayer;

    private Rigidbody2D rbPlayer;
    private bool isGrounded;
    private bool isDoubleJumping;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rbPlayer.velocity = new Vector2(Speed, rbPlayer.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            rbPlayer.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            // RotateSprite();
            isGrounded = false;
        }
    }

    public void DoubleJump()
    {
        if (!isDoubleJumping)
        {
            rbPlayer.velocity = Vector2.zero;
            rbPlayer.AddForce(Vector2.up * JumpForce * 1.5f, ForceMode2D.Impulse);
            isGrounded = false;
            isDoubleJumping = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        foreach (ContactPoint2D point in collision.contacts)
        {
            if (point.normal.x == 0 && point.normal.y > 0)
            {
                isGrounded = true;
                isDoubleJumping = false;
            }
            else
            {
                isGrounded = false;
            }
        }
    }

    public void EndGame()
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(1f);

        Speed = 0;
        JumpForce = 0;
    }
}
