using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Play("Select");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
        FindObjectOfType<AudioManager>().Play("Select");
    }
}
