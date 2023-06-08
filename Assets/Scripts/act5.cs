using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act5 : MonoBehaviour
{
    //act5
public bool funcion1 (int numero)
{
    if(numero % 2 == 0)
{
     return true;
}
    else {return false;}
}
/////////////////////////////////////////////////

//act6

public bool funcion2 (float numero)
{
    if(numero > 0)
{
        return true;
}
    else {return false;}
}

/////////////////////////////////////

//act7

public void funcion3 (float numero)
{
    if(numero <= 0)
{
        Debug.Log ("El numero es menor o igual a 0");
}   else{
        Debug.Log("El numero es mayorque 0");
}
}

////////////////////////

//act 8

public bool funcion4 (int numero)
{
    if(numero == 0)
{
        return true;
}
    else {return false;}
}

///////////////////

//act9

public bool funcion5 (int numero)
{
    if(numero % 4 == 0)
{
        return true;
}
    else {return false;}
}

///////////////////

//act 10

public bool funcion6 (int numero)
{
    if(numero == 5 || numero == 6 || numero == 7)
{
        return true;
}
    else {return false;}
}

/////////////////////////

//act 11

public int funcion7 (string mes)
{
    public int numero;
    if(mes == "january" || mes == "march" || mes == "may" || mes == "july" || mes == "august" || mes == "october" || mes == "december")
{
        numero= 31;
}
    else if (mes == "february")
    {
        numero = 28;
    }
    else
    {
        numero = 30;
    }
    return numero;
}

////////////////////////////

//act 12
public string funcion8 (string mes)
{
    public string estacion;
    if(mes == "march" || mes == "april" || mes == "may")
{
        estacion = "spring";
}
    else if (mes == "june" || mes == "july" || mes == "august")
    {
        estacion = "summer";
    }
    else if (mes == "september" || mes == "october" || mes == "november")
    {
        estacion = "autumm";
    }
    else
    {
        estacion = "winter";
    }
    return mes;
}

/////////////////////

//act13

public void funcion9 (string palabra)
    {
        if (palabra.StartsWith("a") || palabra.StartsWith("A"))
        {
            Debug.Log("La palabra empieza por " + palabra[0]);
        }
        else
        {
            Debug.Log("La palabra no empieza por la letra a / A");
        }
    }

///////////////////////

//ac14

public void funcion10 (string palabra)
    {
        char letra = char.ToLower(palabra [0]);
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            Debug.Log("La palabra empieza por " + letra);
        }
        else
        {
            Debug.Log("La palabra no empieza por vocal");
        }
    }

///////////////

//act15

public bool gameOver;

    public void funcion11()
    {
        if (!gameOver)
        {
            Debug.Log("Seguimos vivos");
        }
        else
        {
            Debug.Log("GAME OVER");
        }
    }

///////////////

//act16

public Vector3 funcion12()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);

        return new Vector3(x, y, z);
    }

    //////////////////
//act17

public Vector3 funcion13(float minValue, float maxValue)
    {
        float x = Random.Range(minValue, maxValue);
        float y = Random.Range(minValue, maxValue);
        float z = Random.Range(minValue, maxValue);

        return new Vector3(x, y, z);
    }

////////////////

//act18

private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
    }

    private void MoveLeft()
    {
        transform.Translate(Vector3.left);
    }

//////////////////

//act19

private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
    }

    private void MoveRight()
    {
        transform.Translate(Vector3.right);
    }

///////////////////

//act20

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveUp();
        }
    }

    private void MoveUp()
    {
        transform.Translate(Vector3.up);
    }

///////////////

//ac21

rivate void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveDown();
        }
    }

    private void MoveDown()
    {
        transform.Translate(Vector3.down);
    }

///////////

//act22

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            direccion(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direccion(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            direccion(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direccion(Vector3.down);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            direccion(Vector3.back);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            direccion(Vector3.forward);
        }
    }

    private void direccion(Vector3 direction)
    {
        transform.Translate(direction);
    }

//////////////

//act23

private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            escala();
        }
    }

    private void escala()
    {
        transform.localScale += new Vector3(1, 1, 1);
    }

/////////////

//act24

private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScaleObject();
        }
    }

    private void ScaleObject()
    {
        Vector3 newScale = transform.localScale - new Vector3(1, 1, 1);
        newScale = Vector3.Max(newScale, Vector3.one);

        transform.localScale = newScale;
    }

///////////////

//act25

  public Color GetRandomColor()
    {
        float red = Random.Range(0f, 1f);
        float green = Random.Range(0f, 1f);
        float blue = Random.Range(0f, 1f);
        
        return new Color(red, green, blue);
    }


}