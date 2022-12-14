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
            currentSpeedState = value;
            speedModifier = (float)value;
            
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
