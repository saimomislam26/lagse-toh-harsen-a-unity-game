using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameend = false;

    public GameObject CmpltLvlUI;
    public GameObject GameendUI;

    public void LevelComplete()
    {
        CmpltLvlUI.SetActive(true);
        Invoke("Next", 2f);
    }

    public void EndGame()
    {
        if(gameend==false)
        {
            gameend = true;
            Debug.Log("Game Over");
            //Invoke("Restart", 2f);
            GameendUI.SetActive(true);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
