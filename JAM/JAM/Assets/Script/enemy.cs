using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public float health = 100f;
    

  
    public void damage( int dmg)
    {
        health -= dmg;
        if(health<=0)
        {
            Destroy(gameObject);
        }
    }
}
