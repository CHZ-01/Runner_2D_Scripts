using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike3 : MonoBehaviour
{
    public float speed;
    public float end = -10;

    // Update is called once per frame
    void Update()
    {
        //spike3 speed
        transform.position += (Vector3.left * speed) * Time.deltaTime;
        
        //spike3 destroy
        if (transform.position.x < end )
        {
            Destroy(gameObject);
        }
    }
}
