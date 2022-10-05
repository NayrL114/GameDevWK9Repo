using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncLoader : MonoBehaviour
{

    public Vector3 pos;
    private string activeScene;
    private bool loadedRight;
    private bool loadedLeft;
    private bool loadedTop;
    private bool loadedBottom;
    
    // Start is called before the first frame update
    void Start()
    {
        // change the code to check through the SceneManager.GetAdtiveScenes array
        // check the unity programming SceneMananger API
    }

    // Update is called once per frame
    void Update()
    {
        activeScene = SceneManager.GetActiveScene().name;
        Debug.Log(pos.x + " " + pos.z + " " + activeScene);
        LoadLevelAsync();
    }

    public void LoadLevelAsync()
    {
        if (pos.x > 0.5f)
        {
            if (!loadedRight)
            //if (!"RightScene".isLoaded)
            {
                SceneManager.LoadSceneAsync("RightScene", LoadSceneMode.Additive);
                loadedRight = true;
            }

            if (loadedLeft)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync("LeftScene");
                loadedLeft = false;
            }
        }
        else if (pos.x < -0.5f)
        {
            if (!loadedLeft)
            //if (!"RightScene".isLoaded)
            {
                SceneManager.LoadSceneAsync("LeftScene", LoadSceneMode.Additive);
                loadedLeft = true;
            }

            if (loadedRight)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync("RightScene");
                loadedRight = false;
            }
        }
        else if (pos.z > 0.5f)
        {
            if (!loadedTop)
            //if (!"RightScene".isLoaded)
            {
                SceneManager.LoadSceneAsync("TopScene", LoadSceneMode.Additive);
                loadedTop = true;
            }

            if (loadedBottom)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync("BottomScene");
                loadedBottom = false;
            }
        }
        else if (pos.z < -0.5f)
        {
            if (!loadedBottom)
            //if (!"RightScene".isLoaded)
            {
                SceneManager.LoadSceneAsync("BottomScene", LoadSceneMode.Additive);
                loadedBottom = true;
            }

            if (loadedTop)
            //if ("LeftScene".isLoaded)
            {
                SceneManager.UnloadSceneAsync("TopScene");
                loadedTop = false;
            }
        }
    }
}
