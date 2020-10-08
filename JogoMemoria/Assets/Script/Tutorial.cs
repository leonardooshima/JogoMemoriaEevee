using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour {
    
    public void QuitTutorial1(){
        SceneManager.LoadScene("areusuret1");
    }
    
    public void QuitTutorial2(){
        SceneManager.LoadScene("areusuret2");
    }
    
    public void QuitTutorial3(){
        SceneManager.LoadScene("areusuret3");
    }
    
    public void QuitTutorial4(){
        SceneManager.LoadScene("areusuret4");
    }
    
    public void QuitTutorial5(){
        SceneManager.LoadScene("areusuret5");
    }
    
    
    
    public void Tutorial2(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void VoltarMenu(){
        
        SceneManager.LoadScene("Menu");
    }
    
    public void BackTutorial(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
    
    //private int gameController = GameController.Instance;
    public void Awake(){
        GameController gameController = GameController.Instance;
        Debug.Log(gameController);
    }
    
    //int y = SceneManager.GetActiveScene().buildIndex;
    //gameController = y;
    
}