using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseControl : MonoBehaviour
{
    public GameObject pausePanel;
    bool gameIsPaused = false;
    void Start()
    {
        pausePanel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Time.timeScale = 0f;
            pausePanel.SetActive(true);
            
        }
    }
}
