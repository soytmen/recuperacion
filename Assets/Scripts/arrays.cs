using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{

    //act 26
    public int[] numeros;

    void Start()
    {
        numeros = new int[] { 1, 2, 3, 4, 5 };

        Debug.Log(numeros[0]);
    }

    ////////////////
//act27

    public float[] numeros2;

    void Start()
    {
        numeros2 = new float[] { 1, 2, 3, 4, 5 };

        Debug.Log(numeros2[0]);
    }

////////////

//act 28

    public string[] numeros3;

    void Start()
    {
        numeros3 = new string[] { "a", "b", "c" };

        Debug.Log(numeros3[2]);
    }

//////////

//act 29

    public string[] numeros4;

    void Start()
    {
        numeros4 = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        for(int i = 1; i< numeros4.Length; i = i+2)
        {

        Debug.Log(numeros4[i]);

        }
    }

/////////////

//act30

public Vector3[] vectorArray;

    void Start()
    {
        vectorArray = new Vector3[10];

        for (int i = 0; i < vectorArray.Length; i++)
        {
            vectorArray[i] = new Vector3(i, i, i);
        }

        for (int i = 0; i < vectorArray.Length; i++)
        {
            if (i % 2 != 0)
            {
                Debug.Log(vectorArray[i]);
            }
        }
    }

///////////////

//act31

public string[] stringArray;

    void Start()
    {
        stringArray = new string[5];

        stringArray[0] = "Hola";
        stringArray[1] = "Mundo";
        stringArray[2] = "OpenAI";
        stringArray[3] = "Unity";
        stringArray[4] = "Programación";

        int randomIndex = Random.Range(0, stringArray.Length);
        Debug.Log(stringArray[randomIndex]);
    }

//////////////

//act 32

public Color[] colorArray;

    void Start()
    {
        colorArray = new Color[10];

        for (int i = 0; i < colorArray.Length; i++)
        {
            colorArray[i] = new Color(Random.value, Random.value, Random.value);
        }

        Debug.Log("El array de colores tiene " + colorArray.Length + " elementos.");
    }

//////////

//act 33

 public GameObject[] gameObjectArray;

    void Start()
    {
        gameObjectArray = new GameObject[5];

        gameObjectArray[0] = GameObject.CreatePrimitive(PrimitiveType.Cube);
        gameObjectArray[1] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        gameObjectArray[2] = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        gameObjectArray[3] = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        gameObjectArray[4] = GameObject.CreatePrimitive(PrimitiveType.Plane);

        int randomIndex = Random.Range(0, gameObjectArray.Length);

        GameObject.Instantiate(gameObjectArray[randomIndex], Vector3.zero, Quaternion.identity);
    }

///////////////

//act 34

public string[] array;

    void Start()
    {

        array = new string[] { "elemento1", "elemento2", "elemento3", "elemento4", "elemento5", "elemento6" };
        
        if (array.Length > 10)
        {
            Debug.Log("El array tiene mas de 10 elementos");
        }
        else
        {
            Debug.Log("El array tiene " + array.Length + " elementos");
        }
    }

//////////

//act35


}
