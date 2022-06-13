using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
public int speed;
public KeyCode upKey; 
public KeyCode downKey;

public KeyCode leftKey; 
public KeyCode rightKey;
 
    private void Start() 
    { 
    } 
 
    private void Update() 
    { 
        // get input 
        Vector3 movement = GetInput(); 
         
        // move object 
        MoveObject(movement); 
    } 
 
    private Vector2 GetInput() 
    { 
        if (Input.GetKey(upKey)) 
        { 
            return Vector2.up * speed; 
        } 
        else if (Input.GetKey(downKey)) 
        { 
            return Vector2.down * speed; 
        }
        if (Input.GetKey(leftKey)) 
        { 
            return Vector2.left * speed; 
        } 
        else if (Input.GetKey(rightKey)) 
        { 
            return Vector2.right * speed; 
        }  
         
        return Vector2.zero;
    } 
 
    private void MoveObject(Vector2 movement) 
    { 
        Debug.Log("TEST: " + movement); 
        transform.Translate(movement * Time.deltaTime); 
    } 
}
