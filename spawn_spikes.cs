using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_spikes : MonoBehaviour
{
    //storing spikes
    [SerializeField] private GameObject[] spikes;
    public float time = 0;
    public float rate = 2;

    // Start is called before the first frame update
    void Start()
    {
        spawn();//spawn spikes
    }

    // Update is called once per frame
    void Update()
    {
        //spawn time creation
        if (time > rate)
        {
            spawn();
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }

    }

    //spawn function
    void spawn()
    {
        GameObject spike_no = spikes[Random.Range(0, spikes.Length)];
        GameObject spike = Instantiate(spike_no, transform.position, Quaternion.identity);
        Rigidbody2D move = spike.GetComponent<Rigidbody2D>();
        //move.velocity = Vector3.left * speed;
    }
}