using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class timebody : MonoBehaviour
{
    public float rectime = 5f;
    public bool isRewinding = false;
    public Rigidbody2D rb;

    List<pointintime> pointINtime;
    // Start is called before the first frame update
    void Start()
    {
        pointINtime = new List<pointintime>();
        rb.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (isRewinding)
            rewind();
        else
            record();
    }

    void rewind()
    {
        if (pointINtime.Count > 0)
        {
            pointintime pointintime = pointINtime[0];
            transform.position = pointintime.position;
            transform.rotation = pointintime.rotation;
            pointINtime.RemoveAt(0);
        }
        else
            stoprewinding();
       
    }

    void record()
    {
        if(pointINtime.Count>Mathf.Round(rectime / Time.deltaTime))
        {
            pointINtime.RemoveAt(pointINtime.Count-1);
        }

            pointINtime.Insert(0, new pointintime(transform.position,transform.rotation));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
            startrewinding();
        if (Input.GetKeyUp(KeyCode.C))
            stoprewinding();
        
    }

    public void startrewinding()
    {
        isRewinding = true;
        rb.isKinematic = true;
    }

    public void stoprewinding()
    {
        isRewinding = false;
        rb.isKinematic = false;
    }
}
