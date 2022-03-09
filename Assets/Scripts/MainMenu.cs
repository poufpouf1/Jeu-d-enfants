using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Play("Select");
    }
    public void Exit()
    {
        Application.Quit();
        FindObjectOfType<AudioManager>().Play("Select");
    }

    public void Options()
    {
        FindObjectOfType<AudioManager>().Play("Select");
    }
}
