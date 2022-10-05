using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    //public SpeedManager spdm;
    private bool isFast = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //isFast ? SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Slow : SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Fast;
            SpeedManager.CurrentSpeedState = (isFast) ? SpeedManager.GameSpeed.Slow : SpeedManager.GameSpeed.Fast;
            /*
            if (isFast)
            {
                SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Slow;
            }
            else
            {
                SpeedManager.CurrentSpeedState = SpeedManager.GameSpeed.Fast;
            }

            */

            isFast = !isFast;
        }

        //SpeedManager.CurrentGameState;

        /*
        Input.GetKeyDown(KeyCode.Space) ? 
            SpeedManager.CurrentSpeedState = (SpeedManager.GameSpeed.Fast, SpeedManager.GameSpeed.Fast) : 
            SpeedManager.CurrentSpeedState = (SpeedManager.GameSpeed.Slow, SpeedManager.GameSpeed.Slow);
        */
    }
}
