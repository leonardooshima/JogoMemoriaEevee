using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level : MonoBehaviour {
    
    public void QuitGame(){
        SceneManager.LoadScene("areusurelevels");
    }
    
    public void Facil(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    
     public void Medio(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
     public void Dificil(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    
    public void VoltarMenu(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }
    
}