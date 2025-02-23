using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike2 : MonoBehaviour
{
    public float speed;
    public float end = -10;

    // Update is called once per frame
    void Update()
    {
        //spike2 speed
        transform.position += (Vector3.left * speed) * Time.deltaTime;
        
        //spike2 destroy
        if(transform.position.x < end)
        {
            Destroy(gameObject);
        }
    }
}
