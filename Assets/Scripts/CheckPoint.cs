using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public SpriteRenderer sr;

    public Sprite On, Off;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Checkcontroller.instance.Desactivado();
            sr.sprite = On;

            Checkcontroller.instance.SetSpawnPoint(transform.position);
        }
        
    }
    public void ResetCheckpoints()
    {
        sr.sprite = Off;
    }
}
