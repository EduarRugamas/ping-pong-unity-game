using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paletas : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool isPaleta1;
    private float yBound = 3.65f;
   
    void Update()
    {
        float move;

       if (isPaleta1)
        {
            move = Input.GetAxisRaw("Vertical");

        }else
        {
            move = Input.GetAxisRaw("Vertical2");
        }

        Vector2 paddlePosition = transform.position;
        paddlePosition.y = Mathf.Clamp(paddlePosition.y + move * speed * Time.deltaTime, -yBound, yBound);
        transform.position = paddlePosition;
        
    }
}
