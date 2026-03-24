using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserScript : MonoBehaviour
{
    public float LaserHorizontalTime;
    public float LaserVerticalTime;
    public GameObject Horizontal;
    public GameObject Vertical;

    // Start is called before the first frame update
    void Start()
    {
        LaserHorizontalTime = 3;
        LaserVerticalTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(LaserHorizontalTime <= 0)
        {
            LaserHorizontalTime = Random.Range(3, 5);
            Instantiate(Horizontal);
        }
        if(LaserVerticalTime <= 0)
        {
            LaserVerticalTime = Random.Range(3, 5);
            Instantiate(Vertical);
        }
        LaserHorizontalTime -= Time.deltaTime;
        LaserVerticalTime -= Time.deltaTime;
    }

    public void DestroyLaser()
    {
        
    }
}
