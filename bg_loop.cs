using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bg_loop : MonoBehaviour
{
    [Range(-1f,5f)]
    public float speed = 0.5f;
    private float offset;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //background lopping
        offset += (speed * Time.deltaTime) / 10;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
