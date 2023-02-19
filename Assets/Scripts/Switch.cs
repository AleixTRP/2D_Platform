using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject objectoSwicth;

    private SpriteRenderer sr;

    public Sprite downsprite;

    private bool hasSiwtch;

    public bool desactivatedSwitch;



    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Player" && !hasSiwtch)
        {
            objectoSwicth.SetActive(false);

        }
        else
        {
            objectoSwicth.SetActive(true);
        }
        sr.sprite = downsprite;
    }

  
}
