using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePos : MonoBehaviour
{
	public Transform checkPoint;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.gameObject.GetComponent<PlayerMovement1>().checkPoint = checkPoint.position;
		}

        if (col.gameObject.tag == "Player2")
        {
            col.gameObject.GetComponent<CharacterControls>().checkPoint = checkPoint.position;
        }
    }
}
