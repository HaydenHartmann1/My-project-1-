using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
			col.gameObject.GetComponent<PlayerMovement1>().LoadCheckPoint();
		}
        if (col.gameObject.tag == "Player2")
        {
            col.gameObject.GetComponent<CharacterControls>().LoadCheckPoint();
        }
    }
}
