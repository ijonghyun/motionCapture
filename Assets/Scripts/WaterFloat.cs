using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFloat : MonoBehaviour
{

    public float waveAmount;
    public float waveDepth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<Rigidbody>() != null)
        {
            print("!");
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (other.transform.position.y < transform.position.y - waveDepth)
            {
                float depth = transform.position.y - other.transform.position.y;
                rb.velocity = Vector3.zero;
                rb.AddForce((waveAmount * Vector3.up), ForceMode.Acceleration);
            }

        }
    }
}
