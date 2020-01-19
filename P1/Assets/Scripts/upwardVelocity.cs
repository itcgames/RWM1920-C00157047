using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upwardVelocity : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f);
    }
}
