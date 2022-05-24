using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rb2 : MonoBehaviour
{
    private BoxCollider2D groundCollider;

    private float groundHorizontalLength;


    // Start is called before the first frame update
    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;

    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
