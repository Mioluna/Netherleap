using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    // Your existing variables

    public void RestartGame()
    {
        SceneManager.LoadScene("Level1Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
        // Note: Quitting the game might not work in the Editor. It will work in a built application.
    }

   
}

