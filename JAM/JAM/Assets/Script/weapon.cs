using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firepoint;
    public int damage = 40;
    public GameObject laserprefab;
    

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();

        }
    }
    public void shoot()
    {
        Instantiate(laserprefab, firepoint.position, firepoint.rotation);
    }
}
