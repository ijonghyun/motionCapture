using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YFixer : MonoBehaviour
{
    float originY;

    private void Start()
    {
        originY = transform.position.y; 
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x, originY, transform.position.z);
    }
}
