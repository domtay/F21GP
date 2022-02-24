using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//class for the menu, allows navigation between different scenece therefor implements SceneManagement
public class MenuNavigation : MonoBehaviour
{
    public void PlayWater()
    {
        SceneManager.LoadScene(1);
    }
    
    public void PlaySandy()
    {
        SceneManager.LoadScene(2);
    }

    public void WinToStart()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
