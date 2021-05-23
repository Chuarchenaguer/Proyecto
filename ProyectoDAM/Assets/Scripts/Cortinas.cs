using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cortinas : MonoBehaviour
{

    float nextTime;
    float modifier;
    // Start is called before the first frame update
    void Start()
    {
        nextTime = 0.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get a random value
        modifier = Random.Range(10.0f, 20.0f);

        //Set nextTime equal to current run time plus modifier
        nextTime = Time.time + modifier;

        //Check if current system time is greater than nextTime
        if (Time.time > nextTime)
        {
            gameObject.GetComponent<Animator>().SetBool("moving", true);
        } else
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }
    }
}
