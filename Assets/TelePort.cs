using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;

    public Transform player2, destination2;
    public GameObject playerg2;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true);
        }

        if (other.CompareTag("Player2"))
        {
            playerg2.SetActive(false);
            player2.position = destination2.position;
            playerg2.SetActive(true);
        }
    }
}