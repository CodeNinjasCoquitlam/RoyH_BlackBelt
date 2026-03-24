using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public float Lives = 4;
    public GameObject LoseMenu;
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Life1.SetActive(true);
        Life2.SetActive(true);
        Life3.SetActive(true);
        LoseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Lives <= 3)
        {
            Life3.SetActive(false);
        }
        if(Lives <= 2)
        {
            Life2.SetActive(false);
        }
        if(Lives <= 1)
        {
            Life1.SetActive(false);
            LoseMenu.SetActive(true);
        }
        Movement();
    }
    //public void OnTrigger2D(Collider2D other)
    //{
    //    if (other.gameObject.CompareTag("Lasers"))
    //    {
    //        Lives -= 1;
    //    }
    //}
    public void Movement()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.up * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.up * speed);
        }
    }
}