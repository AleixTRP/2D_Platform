using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class HealthPlayer : MonoBehaviour
{
    public static HealthPlayer Instance;
    public int currentHealth, maxHealth;
    public float invencible;
    private float CounterInv;
    private SpriteRenderer SR;



    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
        SR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CounterInv > 0)
        {
            CounterInv -= Time.deltaTime;

            if (CounterInv <= 0)
            {
                SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 1f);
            }
        }
    }
    public void DealDamage()
    {
        if (CounterInv <= 0)
        {

            currentHealth--;



            if (currentHealth <= 0)
            {
                currentHealth = 0;
                LvlManager.instance.RespawnPlayer();
            }
            else
            {
                CounterInv = invencible;
                SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, 0.5f);
            }


            UI_Controller.instance.UpdateHealth();
        }



    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            transform.parent = other.transform;
        }
    }


    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            transform.parent = null;
        }
    }
}

