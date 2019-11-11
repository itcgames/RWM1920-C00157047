using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>().transform.position.y > this.GetComponent<Transform>().position.y)
        {
            Transform otherObject = collision.gameObject.GetComponent<Rigidbody>().transform;
            otherObject.SetPositionAndRotation(new Vector3(otherObject.position.x, otherObject.position.y - this.GetComponent<Renderer>().bounds.size.y, otherObject.position.z), new Quaternion());
        }
        else if (collision.gameObject.GetComponent<Rigidbody>().transform.position.y < this.GetComponent<Transform>().position.y)
        {
            Transform otherObject = collision.gameObject.GetComponent<Rigidbody>().transform;
            otherObject.SetPositionAndRotation(new Vector3(otherObject.position.x, otherObject.position.y + this.GetComponent<Renderer>().bounds.size.y + 1.0f, otherObject.position.z), new Quaternion());
        }

    }
}
