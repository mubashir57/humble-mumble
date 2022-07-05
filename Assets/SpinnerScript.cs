using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float xAngle=0f;
    [SerializeField] float yAngle=0f;
    [SerializeField] float zAngle=0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
