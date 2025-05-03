using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Timer timer = FindObjectOfType<Timer>();
            timer.StopTimer();

            GameResult.winnerPlayer = 1; // You can adjust this if Player2 is a different tag
            GameResult.elapsedTime = timer.ElapsedTime;

            SceneManager.LoadScene(2); // Load the End Game scene
        }

        if (other.CompareTag("Player2"))
        {
            Timer timer = FindObjectOfType<Timer>();
            timer.StopTimer();

            GameResult.winnerPlayer = 2; // You can adjust this if Player2 is a different tag
            GameResult.elapsedTime = timer.ElapsedTime2;

            SceneManager.LoadScene(2); // Load the End Game scene
        }
    }
}

public static class GameResult
{
    public static int winnerPlayer;
    public static float elapsedTime;
}
