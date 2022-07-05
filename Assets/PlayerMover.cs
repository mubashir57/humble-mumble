using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Joystick joystick;
    [SerializeField] float moveSpeed=1f;
    float yvalue=0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // float xvalue=Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        // float zvalue=Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        // transform.Translate(xvalue,yvalue,zvalue);

        float xvalue=joystick.Horizontal*Time.deltaTime*moveSpeed;
        float zvalue=joystick.Vertical*Time.deltaTime*moveSpeed;
        transform.Translate(xvalue,yvalue,zvalue);
        
    }
}
