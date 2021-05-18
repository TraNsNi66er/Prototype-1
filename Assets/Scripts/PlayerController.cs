using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //это для объектов
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput; //можно использовать forwarfInput поменять

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //это направление машины
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis ("Vertical");

         //поворачивает машину по вертикали 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput );
        //поворачивает машину по горизонтали
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        
    
    }
}
 