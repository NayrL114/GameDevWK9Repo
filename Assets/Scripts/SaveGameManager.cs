using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    // Loading speed from playerpref is better to be called in Awake(),
    // as if calling it in Start() while the data stored in playerpref is fast,
    // would make the first pressing on Space for changing speed not working, 
    // because I use the isFast boolean in InputManager, while the value of isFast is determined based on the value stored in playerpref. 
    void Awake()
    {
        LoadSpeed();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //LoadSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveSpeed()
    {
        PlayerPrefs.SetInt("Speed", (int)SpeedManager.CurrentSpeedState);
    }

    public void LoadSpeed()
    {
        if (PlayerPrefs.HasKey("Speed"))
        {
            SpeedManager.CurrentSpeedState = PlayerPrefs.GetInt("Speed") == 1 ? SpeedManager.GameSpeed.Slow : SpeedManager.GameSpeed.Fast;
            //SpeedManager.CurrentSpeedState = PlayerPrefs.GetInt("Speed");
        }
    }
}
