using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Used for the restart button of the Game Over screen,
 * This funstion restarts the game by restarting the scene.
 */
public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
