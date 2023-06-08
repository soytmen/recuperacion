using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corrutinas : MonoBehaviour
{
    //act 65

    void Start()
    {
        StartCoroutine(ChangeSphereColor()); 
    }

    IEnumerator ChangeSphereColor()
    {
        while (!gameOver)
        {
            Color randomColor = GetRandomColor(); 
            sphereMaterial.color = randomColor; 

            yield return new WaitForSeconds(colorChangeDelay); 
        }
    }

///////////

//act66

    void Start()
    {
        StartCoroutine(ChangeCubeScale()); 
    }

    IEnumerator ChangeCubeScale()
    {
        while (!gameOver)
        {
            Vector3 randomScale = GetRandomScale(); 
            cube.transform.localScale = randomScale; 

            yield return new WaitForSeconds(scaleChangeDelay); 
        }
    }

    Vector3 GetRandomScale()
    {
        float scaleX = Random.Range(0.1f, 2f); 
        float scaleY = Random.Range(0.1f, 2f); 
        float scaleZ = Random.Range(0.1f, 2f); 

        return new Vector3(scaleX, scaleY, scaleZ); 
    }

    
    public void GameOver()
    {
        gameOver = true;
    }

///////////

//act67

void Start()
    {
        StartCoroutine(ChangeCylinderPosition()); // Iniciar la corrutina
    }

    IEnumerator ChangeCylinderPosition()
    {
        int currentIndex = 0;

        while (currentIndex < positions.Length)
        {
            Vector3 newPosition = positions[currentIndex];
            cylinder.transform.position = newPosition;

            yield return new WaitForSeconds(1f); // Esperar un segundo

            currentIndex++;
        }
    }

///////

//act 69

 void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isRunning = false; // Detener la corrutina cuando se pulsa la tecla Intro
        }
    }

    void Start()
    {
        StartCoroutine(ChangeCubeRotation()); // Iniciar la corrutina
    }

    IEnumerator ChangeCubeRotation()
    {
        while (isRunning)
        {
            cube.transform.Rotate(Vector3.up, 20f, Space.Self); // Rotar el cubo 20º en sentido de las agujas del reloj

            yield return new WaitForSeconds(0.5f); // Esperar medio segundo antes de la próxima rotación
        }
    }

//////////

//act70

private void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        int index = 0;
        while (index < message.Length)
        {
            textMeshPro.text += message[index];
            index++;

            yield return new WaitForSeconds(0.2f);
    }
    }



}

