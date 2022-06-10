using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame() 
    { 
        SceneManager.LoadScene("SampleScene"); 
    } 

        public void OpenAuthor() 
    { 
        Debug.Log("Created By Kent"); 
    } 
       // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
