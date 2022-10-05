using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{

    private static float speedModifier = 1.0f;    
    public static float SpeedModifier
    {
        get
        {
            return speedModifier;
        }
    }

    public enum GameSpeed
    {
        Slow = 1,// 1 
        Fast = 3,// 3
    }
    private static GameSpeed currentSpeedState = GameSpeed.Slow;
    public static GameSpeed CurrentSpeedState
    {
        get
        {
            return currentSpeedState;
        }
        set
        {
            if (currentSpeedState == GameSpeed.Fast)
            {
                currentSpeedState = GameSpeed.Slow;
                speedModifier = (float)GameSpeed.Slow;
            }
            else
            {
                currentSpeedState = GameSpeed.Fast;
                speedModifier = (float)GameSpeed.Fast;
            }
            
        }
    }
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}