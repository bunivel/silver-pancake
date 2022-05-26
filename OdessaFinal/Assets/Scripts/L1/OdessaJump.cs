using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdessaJump : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public bool isOnGround;
    public float jumpForce = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        isOnGround = true;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        isOnGround = false;
    }
}

