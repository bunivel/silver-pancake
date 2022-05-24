using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdessaController : MonoBehaviour
{
    public float upForce = 200f;

    Rigidbody2D rigidbody2D;


    Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        transform.position = position;

        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(new Vector2(0, upForce));
        }

        void FixedUpdate()
        {
            animator.SetFloat("Move X", 0);
        }
    }
}
