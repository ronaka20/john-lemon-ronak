using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinrotation : MonoBehaviour
{
   public int coinrotatespeed;
    void FixedUpdate()
    {
        transform.Rotate(0,coinrotatespeed,0,Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="JohnLemon")
        {   other.GetComponent<scorecheck>().point++;
            Destroy(gameObject);}
    }
}
