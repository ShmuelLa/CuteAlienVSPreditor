using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Deletes the player on hitting an enemy object, 
 * This component will also activate the GameOver UI component and finish the game
 */
public class DestroyOnTrigger : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public GameObject GameOverScreen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
            GameOverScreen.SetActive(true);
        }
    }
}
