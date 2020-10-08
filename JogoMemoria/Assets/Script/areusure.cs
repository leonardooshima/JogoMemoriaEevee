using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class areusure : MonoBehaviour {
    
    public void sim(){
        Debug.Log("Quit!");
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
    public void nao(){
        Debug.Log(GetLastSceneNumber());
        Debug.Log("aa"+SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 13);
        
    }
    
    
     public void naoLevels(){
        SceneManager.LoadScene("Levels");
    }
    
    public void naoCredits(){
        SceneManager.LoadScene("Credits");
    }
    
    public void naoGanhou(){
        SceneManager.LoadScene("ganhou");
    }
    
    public void naoPerdeu(){
        SceneManager.LoadScene("Perdeu");
    }
    
    public void naoscene2(){
        SceneManager.LoadScene("Scene2");
    }
    
    public void naoscene3(){
        SceneManager.LoadScene("Scene3");
    }
    
    public void naoscene4(){
        SceneManager.LoadScene("Scene4");
    }
    
    public void naoscene5(){
        SceneManager.LoadScene("Scene5");
    }
    
    public void naoTutorial1(){
        SceneManager.LoadScene("Tutorial1");
    }
    
    public void naoTutorial2(){
        SceneManager.LoadScene("Tutorial2");
    }
    
    public void naoTutorial3(){
        SceneManager.LoadScene("Tutorial3");
    }
    
    public void naoTutorial4(){
        SceneManager.LoadScene("Tutorial4");
    }
    
    public void naoTutorial5(){
        SceneManager.LoadScene("Tutorial5");
    }
    
    
    


    // we can use the SceneUnloaded delegate of scenemanager to listen for scenes that have been unloaded
    void OnEnable()        {    SceneManager.sceneUnloaded += SceneUnloadedMethod;        }
    void OnDisable()        {    SceneManager.sceneUnloaded -= SceneUnloadedMethod;        }
    
    int lastSceneIndex = -1;

    // looks a bit funky but the method signature must match the scenemanager delegate signature
    void SceneUnloadedMethod (Scene sceneNumber){
        int sceneIndex = sceneNumber.buildIndex;
        // only want to update last scene unloaded if were not just reloading the current scene
        if(lastSceneIndex != sceneIndex){
            lastSceneIndex = sceneIndex;
            Debug.Log("unloaded scene is : " + lastSceneIndex);
        }
    }
        public int GetLastSceneNumber(){
                return lastSceneIndex;
        }
    //private GameController gameController = GameController.Instance;
}