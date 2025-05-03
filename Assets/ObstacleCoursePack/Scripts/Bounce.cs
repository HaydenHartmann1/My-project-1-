using UnityEngine;

public class BouncePadScript : MonoBehaviour
{
    public float bounceForce = 10000f; // Adjust this value for the desired bounce height

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding is the player (you can use tags for this)
        if (other.CompareTag("Player")) // Replace "Player" with your player's tag
        {
            // Apply an upward force to the player's Rigidbody
            Rigidbody playerRigidbody = other.GetComponent<Rigidbody>();

            if (playerRigidbody != null)
            {
                playerRigidbody.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
            }
        }
    }
}