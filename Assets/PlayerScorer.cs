using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScorer : MonoBehaviour
{
    // Start is called before the first frame update
   int hits=0;
   private void OnCollisionEnter(Collision other) 
   {
        
        Debug.Log("Total Hits: "+hits);
         Debug.Log("reahn");
        

        hits++;
   }
}
