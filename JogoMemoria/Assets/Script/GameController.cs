using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public  class GameController : MonoBehaviour {

    // Make global
    
    public int index=1;
    
    public static GameController Instance {
        get;
        set;
    }

    void Awake () {
        DontDestroyOnLoad(transform.gameObject);
        Instance = this;
    }

    void Start() {
        //Load first game scene (probably main menu)
        SceneManager.LoadScene("ganhou");
    }

}

