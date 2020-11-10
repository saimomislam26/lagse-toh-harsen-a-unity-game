using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public movement player;
  void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            player.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
