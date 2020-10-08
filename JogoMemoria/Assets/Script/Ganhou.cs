using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganhou : MonoBehaviour {
    
    public void QuitGame(){
        SceneManager.LoadScene("areusureganhou");
    }
    
    public void QuitScene2(){
        SceneManager.LoadScene("areusurescene2");
    }
    
    public void QuitScene3(){
        SceneManager.LoadScene("areusurescene3");
    }
    
    public void QuitScene4(){
        SceneManager.LoadScene("areusurescene4");
    }
    
    public void VoltarMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 11);
    }
    
    public void level(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
}