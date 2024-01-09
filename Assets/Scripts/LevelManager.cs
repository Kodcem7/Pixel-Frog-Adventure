using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public float waitToRespawn;
    
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCO());
    }
    private IEnumerator RespawnCO()
    {
        PlayerController.instance.gameObject.SetActive(false);
        UIController.instance.UpdateHealthDisplay();
        yield return new WaitForSeconds(waitToRespawn);
        PlayerController.instance.gameObject.SetActive(true);
        PlayerController.instance.transform.position = CheckpointController.instance.spawnpoint;
        PlayerHealthController.instance.currentHealth = 3;
        UIController.instance.UpdateHealthDisplay();
        
    }
}
