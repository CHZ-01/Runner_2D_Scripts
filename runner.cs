using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class runner : MonoBehaviour
{
    public Rigidbody2D gravity;
    public Animator animate;
    public float jump;
    float up;
    public game_over lost;
    public bool alive = true;

    // Update is called once per frame
    void Update()
    {
        //jump function
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            gravity.velocity = Vector2.up * jump;
        }

        //jump animation
        if(gravity.velocity.y > 0.1f)
        {
            animate.SetBool("Jump", true);
        }

        if (transform.position.y <= -1.474272f)
        {
            animate.SetBool("Jump", false);
        }

    }

    //destroy player on hit
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "obstacle")
        {
            Destroy(gameObject);
            lost.over();
            alive = false;
        }
    }
}
