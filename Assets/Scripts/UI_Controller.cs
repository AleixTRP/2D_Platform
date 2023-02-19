using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public static UI_Controller instance;

    public Image Vida, Vida2, Vida3;

    public Sprite vidafull, vidaempty, vidahalf;

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

    public void UpdateHealth()
    {
        switch (HealthPlayer.Instance.currentHealth)

        {
            case 6:
                Vida.sprite = vidafull;
                Vida2.sprite = vidafull;
                Vida3.sprite = vidafull;

                break;

            case 5:
                Vida.sprite = vidafull;
                Vida2.sprite = vidafull;
                Vida3.sprite = vidahalf;

                break;

            case 4:
                Vida.sprite = vidafull;
                Vida2.sprite = vidafull;
                Vida3.sprite = vidaempty;

                break;

            case 3:
                Vida.sprite = vidafull;
                Vida2.sprite = vidahalf;
                Vida3.sprite = vidaempty;

                break;

            case 2:

                Vida.sprite = vidafull;
                Vida2.sprite = vidaempty;
                Vida3.sprite = vidaempty;

                break;

            case 1:

                Vida.sprite = vidahalf;
                Vida2.sprite = vidaempty;
                Vida3.sprite = vidaempty;

                break;
           
            case 0:

                Vida.sprite = vidaempty;
                Vida2.sprite = vidaempty;
                Vida3.sprite = vidaempty;
               
                break;

            default:

                Vida.sprite = vidaempty;
                Vida2.sprite = vidaempty;
                Vida3.sprite = vidaempty;

                break;


        }
    }
}
