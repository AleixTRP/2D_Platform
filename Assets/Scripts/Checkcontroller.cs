using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkcontroller : MonoBehaviour
{
   public static Checkcontroller instance;
   
    public CheckPoint[] checkpoints;

    public Vector3 spawnPoint;


    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        checkpoints = FindObjectsOfType<CheckPoint>(); 
         
        spawnPoint = ControllerPlayer.instance.transform.position;
    }
    public void Desactivado()
    {
        for( int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckpoints();
        }
    }
    
    public void SetSpawnPoint(Vector3 newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;    
    }
}
