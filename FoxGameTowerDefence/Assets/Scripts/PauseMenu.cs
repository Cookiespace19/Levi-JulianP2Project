using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject ResumeButton;
    public GameObject SettingsButton;
    public GameObject QuitButton;

    public GameObject SensitivitySliderUI;
    public GameObject AudioSliderUI;
    public GameObject BackButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {    //stop everything. were paused
            Pause();
        }
    }

     void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Settings()
    {
        ResumeButton.SetActive(false);
        SettingsButton.SetActive(false);
        QuitButton.SetActive(false);

        SensitivitySliderUI.SetActive(true);
        AudioSliderUI.SetActive(true);
        BackButton.SetActive(true);

    }

    public void Back()
    {

        SensitivitySliderUI.SetActive(false);
        AudioSliderUI.SetActive(false);
        BackButton.SetActive(false);

        SettingsButton.SetActive(true);
        ResumeButton.SetActive(true);
        QuitButton.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
