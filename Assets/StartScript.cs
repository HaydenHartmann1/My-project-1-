using UnityEngine;

public class StartTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<Timer>().StartTimer();
            // Debug.Log("1 Player Enter Test");
        }
        if (other.CompareTag("Player2"))
        {
            FindObjectOfType<Timer>().StartTimer2();
            // Debug.Log("2 Player Enter Test");
        }
    }
}


