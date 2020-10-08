using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour {
    
    public void QuitGame(){
        SceneManager.LoadScene("areusurecredits");
    }
    
    public void VoltarMenuCredits(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    
}