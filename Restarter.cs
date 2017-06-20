using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
				print ("player touched killzone, Restart level"); //when the player touches the killzone, it restarts the level
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
        }
    }
}
