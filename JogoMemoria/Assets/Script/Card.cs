using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {
    public static bool DO_NOT = false;
    
    [SerializeField]
    private int _state;
    [SerializeField]
    private int _cardValue;
    [SerializeField]
    private bool _initialized = false;
    
    private Sprite _cardBack;
    private Sprite _cardFace;
    
    
    private GameObject _manager;
    
    void Start() {
        _state = 1;
        _manager = GameObject.FindGameObjectWithTag ("Manager");
        //float timeLeft = 3.0f;
        //StartCoroutine(StartCountdown());
        
    }
    
   // void Update(){
        
        /*
         
         timeLeft -= Time.deltaTime;
         if(timeLeft < 0)
         {
             Debug.Log("iuguuigiukgbku");
             state=0;
         }
         */
     //}
    /*
    float currCountdownValue;
    public IEnumerator StartCountdown(float countdownValue = 3){
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0){
         Debug.Log("Countdown: " + currCountdownValue);
         yield return new WaitForSeconds(1.0f);
         currCountdownValue--;
     }
        Debug.Log("lwozinho");
        _state=1;
        Debug.Log("lwozinho" + _state);
        
    }
 */
        
    
    public void setupGraphics(){
        _cardBack = _manager.GetComponent<GameManager> ().getCardBack ();
        _cardFace = _manager.GetComponent<GameManager> ().getCardFace (_cardValue);
        DO_NOT = false;
        
        flipCard ();
    }
    
    public void flipCard(){
        if (DO_NOT)
            return;
        
        if (_state == 0)
            _state = 1;
        else if (_state == 1)
            _state = 0;
        
        if(_state == 0 && !DO_NOT)
            GetComponent<Image> ().sprite = _cardBack;
        else if (_state == 1 && !DO_NOT)
            GetComponent<Image> ().sprite = _cardFace;
    }
    
    public int cardValue {
        get { return _cardValue; }
        set { _cardValue = value; }
    }
    
    public int state {
	   get { return _state; }
	   set { _state = value; }
    }

    public bool initialized {
	   get { return _initialized; }
	   set { _initialized = value; }
    }
    
    public void falseCheck() {
        StartCoroutine (pause ());
    }
    
    IEnumerator pause(){
        yield return new WaitForSeconds(1);
        if (_state == 0)
            GetComponent<Image> ().sprite = _cardBack;
        else if (_state == 1)
             GetComponent<Image> ().sprite = _cardFace;
        DO_NOT = false;
    } 
}
