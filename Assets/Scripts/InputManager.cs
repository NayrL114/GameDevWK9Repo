using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{

    //public SpeedManager spdm;
    private bool isFast = false;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedManager.CurrentSpeedState = (isFast) ? SpeedManager.GameSpeed.Slow : SpeedManager.GameSpeed.Fast;
            isFast = !isFast;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && GameManager.currentGameState == GameManager.GameState.Start)
        {
            //GameManager.currentGameState = GameManager.GameState.Start;
            GameManager.currentGameState = GameManager.GameState.WalkingLevel;
            gameObject.GetComponent<Tweener>().enabled = false;
            SceneManager.LoadScene("WalkingScene");
            
        }
        
    }
}
