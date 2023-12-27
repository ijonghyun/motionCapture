using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CameraWalkAfterDive : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Animator>() != null)
        {
            Debug.Log(11);
            other.GetComponent<Animator>().SetBool("Dive",true);
        }
    }
}
