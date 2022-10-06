using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadSpeed();
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
