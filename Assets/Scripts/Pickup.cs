using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isHeal;
    private bool isCollected;
    public GameObject pickUpEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !isCollected)
        {
            if(isHeal)
            {
                if(PlayerHealthController.instance.currentHealth != PlayerHealthController.instance.maxHealth)
                {
                    PlayerHealthController.instance.HealPlayer();

                    isCollected = true;
                    Destroy(gameObject);
                    Instantiate(pickUpEffect,transform.position,transform.rotation);
                }
            }
        }
    }
}
