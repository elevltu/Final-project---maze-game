using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseGameButton : MonoBehaviour
{
    public GameObject pauseText;
    public GameObject mainMenuButton;
    public GameObject resumeButton;
    // Start is called before the first frame update
    public void unpauseGame()
    {
        Time.timeScale = 1.0f;
        pauseText.SetActive(false); mainMenuButton.SetActive(false); resumeButton.SetActive(false);
        PauseGame.gameIsPaused = false;
    }
}
