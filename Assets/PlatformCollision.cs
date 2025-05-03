using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] string PlayerTag = "Player";
    [SerializeField] Transform platform;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals(PlayerTag)) 
        {
            other.gameObject.transform.parent = platform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals(PlayerTag))
        {
            other.gameObject.transform.parent = null;
        }
    }
}
