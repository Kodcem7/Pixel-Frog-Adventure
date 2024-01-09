using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{

    public static PlayerHealthController instance;
    public int currentHealth , maxHealth;
    private void Awake()
    {
        instance = this;
    }
    public float invincibleLength;
    private float invincibleCounter;
    private SpriteRenderer theSR;

    void Start()
    {
        currentHealth = maxHealth;
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(invincibleCounter > 0 )
        {
            invincibleCounter -= Time.deltaTime;

            if(invincibleCounter <= 0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }
        }
    }
    
    public void DealDamage()
    {
        if(invincibleCounter <= 0)
        {
            currentHealth -= 1;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            //gameObject.SetActive(false);
            LevelManager.instance.RespawnPlayer();

            
        }else
        {
            invincibleCounter = invincibleLength;
            PlayerController.instance.KnockBack();
            theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
        }
        UIController.instance.UpdateHealthDisplay();
        }
        
    }
    public void HealPlayer()
    {
        currentHealth++;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UIController.instance.UpdateHealthDisplay();
    }
}
