using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike1 : MonoBehaviour
{
    public float speed;
    public float end = -10;

    // Update is called once per frame
    void Update()
    {
        //spike1 speed
        transform.position += (Vector3.left * speed) * Time.deltaTime;
        
        //spike1 destroy
        if(transform.position.x < end)
        {
            Destroy(gameObject);
        }
    }
}
