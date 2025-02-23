using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class score_count : MonoBehaviour
{
    public float run_score;
    public Text text_score;

    private void Update()
    {
        //score count function
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            run_score += 10 * Time.deltaTime;
            text_score.text = ((int)run_score).ToString();
        }
    }
    


}