using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncLoader : MonoBehaviour
{

    public Vector3 pos;

    //private string activeScene;
    //private int activeSceneNumbers;
    private bool loadedRight;
    private bool loadedLeft;
    private bool loadedTop;
    private bool loadedBottom;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        activeScene = SceneManager.GetActiveScene().name;
        activeSceneNumbers = SceneManager.sceneCount;
        Debug.Log(pos.x + " " + pos.z + " " + activeScene + " " + activeSceneNumbers);
        */
        LoadLevelAsync();
    }

    public void LoadLevelAsync()
    {
        // Top Scene is 2, Bottom Scene is 3, Left Scene is 4, Right Scene is 5
        if (pos.x > 2.5f)
        {
            if (!loadedRight)
            //if (SceneManagement.RightScene.isLoaded)
            {
                SceneManager.LoadSceneAsync(5, LoadSceneMode.Additive);
                loadedRight = true;
            }

            if (loadedLeft)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync(4);
                loadedLeft = false;
            }
        }

        if (pos.x < -2.5f)
        {
            if (!loadedLeft)
            //if (!"RightScene".isLoaded)
            {
                SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
                loadedLeft = true;
            }

            if (loadedRight)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync(5);
                loadedRight = false;
            }
        }

        if (pos.z > 2.5f)
        {
            if (!loadedTop)
            //if (!"RightScene".isLoaded)
            {
                SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);
                loadedTop = true;
            }

            if (loadedBottom)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync(3);
                loadedBottom = false;
            }
        }

        if (pos.z < -2.5f)
        {
            if (!loadedBottom)
            //if (!"RightScene".isLoaded)
            {
                SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);
                loadedBottom = true;
            }

            if (loadedTop)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync(2);
                loadedTop = false;
            }
        }
    }
}
