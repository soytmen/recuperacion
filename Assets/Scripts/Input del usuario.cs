using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputdelusuario : MonoBehaviour
{
/////

//act84

 public float speed = 5f; // Velocidad de movimiento

    private void Update()
    {
        // Obtener las entradas de los ejes "Horizontal" y "Vertical"
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * speed;

        // Actualizar la posición del cubo mediante el componente Transform
        transform.position += movement * Time.deltaTime;
    }

//////////

//act85

public float speed = 5f; // Velocidad de movimiento
    public float screenBoundary = 5f; // Límite de la pantalla

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * speed * Time.deltaTime;

        Vector3 newPosition = transform.position + movement;
       
        newPosition.x = Mathf.Clamp(newPosition.x, -screenBoundary, screenBoundary);
        newPosition.z = Mathf.Clamp(newPosition.z, -screenBoundary, screenBoundary);

        transform.position = newPosition;
    }

///////////

//act86

public float speed = 5f; 
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; 
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * speed;

        rb.AddForce(movement);
    }
//////////

//act 88

 public float rotationSpeed = 100f; 

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
    }

////////////

//act89

    public float rotationSpeed = 100f; 

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        float rotationAngle = horizontalInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(0f, rotationAngle, 0f);
    }
}
