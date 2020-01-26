using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    bool active = true;
    public AudioSource pipeSource;
    public AudioClip pipeClip;
    private void Start()
    {
        pipeSource.clip = pipeClip;
    }
    private void Update()
    {
       // pipeSource.volume = PlayerPrefs.GetFloat("volume");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
            pipeSource.Play();
            if (collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y > this.GetComponent<Transform>().position.y)
            {
                Debug.Log("Downcollision");
                Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
                otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y - this.GetComponent<Renderer>().bounds.size.y - otherObj.GetComponent<Renderer>().bounds.size.y - 0.05f, otherObj.position.z), new Quaternion());
            }
            else if (collision.gameObject.GetComponent<Rigidbody2D>().transform.position.y < this.GetComponent<Transform>().position.y)
            {
                Debug.Log("Upcollision");
                Transform otherObj = collision.gameObject.GetComponent<Rigidbody2D>().transform;
                otherObj.SetPositionAndRotation(new Vector3(otherObj.position.x, otherObj.position.y + this.GetComponent<Renderer>().bounds.size.y + 0.05f + otherObj.GetComponent<Renderer>().bounds.size.y, otherObj.position.z), new Quaternion());
            }
    }
    public void changeAlive()
    {
        if(active)
        {
            active = false;
        }
        else
        {
            active = true;
        }
    }
}
