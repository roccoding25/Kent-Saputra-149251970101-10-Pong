using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
public Vector2 speed; 
public Vector2 resetPosition;
    private void Start() 
    { 
        
    } 
 
    private void Update() 
    { 
        transform.Translate(speed * Time.deltaTime); 
    } 
        public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1); 
    } 
}
