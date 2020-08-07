
using UnityEngine;


public class bullet : MonoBehaviour
{

    
    public Rigidbody2D rb;
    public float laserspd = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * laserspd;
    }

   //detect and damage
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name=="enemy")
        {
            Debug.Log("enemy");
            
        }
       
    }

    

}    
