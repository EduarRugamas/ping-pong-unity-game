using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    private Rigidbody2D ballRB;
    [SerializeField] private float velocityInitial = 4f;
    [SerializeField] private float velocityMultiplier = 1.1f;
    void Start()
    {
        ballRB = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;

        ballRB.velocity = new Vector2(xVelocity, yVelocity) * velocityInitial;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paleta"))
        {
            ballRB.velocity *= velocityMultiplier;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("meta-1"))
        {
            GameManager.Instance.PaletaPuntos2();
            GameManager.Instance.Restart();
            Launch();
        }
        else
        {
            GameManager.Instance.PaletaPuntos1();
            GameManager.Instance.Restart();
            Launch();
        }
    }
}
