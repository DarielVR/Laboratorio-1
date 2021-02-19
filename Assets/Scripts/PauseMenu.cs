using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{   
    public GameObject pauseMenu;
    public AudioSource menu;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            TogglePause();
        }
    }

    public void TogglePause() {
        menu.Play();
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        Time.timeScale = pauseMenu.activeSelf ? 0.0f: 1.0f;
    }

    public void Reload () {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame () {
        Application.Quit();
    }
    
}
