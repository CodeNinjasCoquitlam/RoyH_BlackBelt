using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour
{
    private Player player;
    public bool Damage;
    public bool Exit;
    public bool Destroy;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        Damage = false;
        Exit = true;
        Destroy = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Destroy == true)
        {
            Destroy(gameObject);
        }
    }

    public void OnTrigger2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && Damage == true && Exit == true)
        {
            Exit = false;
            player.Lives -= 1;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        Exit = true;
    }
}
