using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LvlManager : MonoBehaviour
{
     public static LvlManager instance;

    public float waitRespawn;


    private void Awake()
    {
        instance = this;
    }

  
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCorutine());

    }

    IEnumerator RespawnCorutine()
    {
        ControllerPlayer.instance.gameObject.SetActive(false);

        yield return new WaitForSeconds(waitRespawn);

        ControllerPlayer.instance.gameObject.SetActive(true);

        ControllerPlayer.instance.transform.position = Checkcontroller.instance.spawnPoint;

        HealthPlayer.Instance.currentHealth = HealthPlayer.Instance.maxHealth;
        
    }
}
