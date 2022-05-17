using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed;
    public GameObject rocket;
    private Rigidbody2D rb2d;
    public bool play = false;
    private CompositeCollider2D collider2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<CompositeCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!play)
        {
            rb2d.velocity = new Vector2(0, 0);
        }
        if (play)
        {
            rb2d.velocity = new Vector2(speed, -3);
        } 
    }
   void OnCollisionEnter2D(Collision2D other)
    {
        rocket = other.gameObject;
    }
}
