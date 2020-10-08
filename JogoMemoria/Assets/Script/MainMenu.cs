using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    
    public void QuitGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 13);
    }
    
    public void Tutorial1(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    
    public void Credits(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
}
