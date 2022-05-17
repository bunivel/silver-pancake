using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    public float groundHorizontalLeangth;
    public float repeatSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLeangth)
        {
            RepositionBackground();
        }
    }
    private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLeangth * repeatSpeed, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
