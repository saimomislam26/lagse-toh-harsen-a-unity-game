using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLCMPLT : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
   void OnTriggerEnter(Collider Collisioninfo)
    {
        if (Collisioninfo.tag == "obstacle")
        {
            Invoke("Restart", 2f);
        }
        else
        {
            gameManager.LevelComplete();
        }
           
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
