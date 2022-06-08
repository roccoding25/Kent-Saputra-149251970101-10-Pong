using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
public Vector2 speed; 
 
    private void Start() 
    { 
        
    } 
 
    private void Update() 
    { 
        transform.Translate(speed * Time.deltaTime); 
    } 
}
