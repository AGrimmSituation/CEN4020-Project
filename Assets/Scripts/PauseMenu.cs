using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    [SerializeField] GameObject pauseMenuUI = null;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        paused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        paused = true;
    }

    public void GoToTitleScreen()
    {
        SaveSystem.SaveGame();
        SceneManager.LoadScene("Title Screen");
        paused = false;
    }

    public void SaveAndQuit()
    {
        SaveSystem.SaveGame();
        paused = false;
        Application.Quit();
    }


    public void Quit()
    {
        paused = false;
        Application.Quit();
    }
}
