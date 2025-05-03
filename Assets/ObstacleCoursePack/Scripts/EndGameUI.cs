using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameUI : MonoBehaviour
{
    public TMP_Text resultText; // Drag your TMP Text component here in the Inspector

    void Start()
    {
        float time = GameResult.elapsedTime;
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        int milliseconds = Mathf.FloorToInt((time * 1000) % 1000);

        resultText.text = $"Player {GameResult.winnerPlayer} Wins\nTime: {minutes:D2}:{seconds:D2}.{milliseconds:D3}";
    }
}
