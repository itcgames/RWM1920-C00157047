using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpwardVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vel = this.gameObject.GetComponent<Rigidbody>().velocity;
        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(vel.x, 1.0f, vel.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
