using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
public Vector2 speed; 
private Vector2 resetPosition;

private Rigidbody2D rb;
    private void Start() 
    { 
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;

    } 
 
    private void Update() 
    { 
        
    } 
        public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1); 
        rb.velocity = speed;
    }
    public void ActivatePUSpeedUp (float magnitude)
{
    rb.velocity *= magnitude;
} 
}
