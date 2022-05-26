using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public bool gameOver;
    public ScrollingObject scroll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            scroll.scrollSpeed = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        gameOver = true;
    }
}
