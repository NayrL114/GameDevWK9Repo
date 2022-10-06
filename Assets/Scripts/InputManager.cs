using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{

    //public SpeedManager spdm;
    private bool isFast = false;
    public SaveGameManager sgm;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        sgm = gameObject.GetComponent<SaveGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedManager.CurrentSpeedState = (isFast) ? SpeedManager.GameSpeed.Slow : SpeedManager.GameSpeed.Fast;
            isFast = !isFast;
            //SaveGameManager.SaveSpeed();
            sgm.SaveSpeed();
        }

        if (Input.GetKeyDown(KeyCode.Return) && GameManager.currentGameState == GameManager.GameState.Start)
        {
            //GameManager.currentGameState = GameManager.GameState.Start;
            GameManager.currentGameState = GameManager.GameState.WalkingLevel;
            gameObject.GetComponent<Tweener>().enabled = false;
            SceneManager.LoadScene(0);// WalkingScene is identified as scene 0 in the build
            
        }
        
    }
}
