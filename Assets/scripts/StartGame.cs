using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void loadScene()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(sceneName);
    }
}
