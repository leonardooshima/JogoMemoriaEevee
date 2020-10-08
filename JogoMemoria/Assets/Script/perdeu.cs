using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perdeu : MonoBehaviour {
    
    public void QuitGame(){
        SceneManager.LoadScene("areusureperdeu");
    }
    
    public void VoltarMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }
    
    public void PlayAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}