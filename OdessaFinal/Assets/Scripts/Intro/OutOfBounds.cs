using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfBounds : MonoBehaviour
{
    public GameObject ofb;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Crystal");
    }
}
