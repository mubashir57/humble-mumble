using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallsCollision : MonoBehaviour
{
    // Start is called before the first frame update
   private void OnCollisionEnter(Collision other) 
   {
    if(other.gameObject.tag=="Player")
    {GetComponent<MeshRenderer>().material.color=Color.red;}
   }
}
