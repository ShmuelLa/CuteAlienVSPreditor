using UnityEngine;

/**
 * This component moves the enemy predator object in a fixed velocity.
 * velocity is defined as speed+direction.
 */
public class EnemyMover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;

    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}
