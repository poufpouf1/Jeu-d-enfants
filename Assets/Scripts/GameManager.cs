using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        Time.timeScale = 1f;
    }

    int nbOfBlocks;
    public Text blockText;

    public GameObject winMenuUI;

    void Update()
    {
        nbOfBlocks = GameObject.FindGameObjectsWithTag("Block").Length;

        if(nbOfBlocks <= 0)
        {
            Debug.Log("WIN");
            FindObjectOfType<AudioManager>().Play("Win");
            Win();
        }

        Debug.Log(nbOfBlocks);

        blockText.text = "Blocks " + nbOfBlocks;
    }

    void Win()
    {
        winMenuUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
}
