using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    
    
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        //moving player by keyborad
        if (Input.GetKey(KeyCode.W))
        {
           transform.Translate(Vector3.forward * 5.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * -5.0f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5.0f * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * -5.0f * Time.deltaTime);
        }

        //moving direction by mouse
        Vector3 lookdirection = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Quaternion rotation = Quaternion.LookRotation(lookdirection, Vector3.up);



    }

    private void FixedUpdate()
    {
       
    }
}
