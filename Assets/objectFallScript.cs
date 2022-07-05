using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFallScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float timeToWait=5f;
    MeshRenderer render;
    Rigidbody rgb;
    
    void Start()
    {
        render= GetComponent<MeshRenderer>();
        rgb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=timeToWait )
        {
            Debug.Log("Three Seconds Passed");
            rgb.useGravity=true;
            render.enabled=true;

            
        }
    }
}
