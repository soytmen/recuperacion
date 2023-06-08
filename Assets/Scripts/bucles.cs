using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucles : MonoBehaviour
{
//act 35
for (int i = 0; i<=10; i++)
{
    Debug.Log(i);
}

////////////

//act 36

for (int i = 0; i<=100; i++)
{
    Debug.Log(i);
}

//////////
//act 37

for (int i = 10; i>=0; i--)
{
    Debug.Log(i);
}

/////////

//act 38
for (int i = 100; i>=0; i--)
{
    Debug.Log(i);
}

/////////

//act 39

for (int i = 2; i<=100; i = i+2)
{
    Debug.Log(i);
}

////////////

//act 40

for (int i = 99; i>=0; i=i-2)
{
    Debug.Log(i);
}

////////

//act41

for (int i = 100; i <= 200; i++)
        {
            if (i % 5 == 0)
            {
                Debug.Log(i);
            }
        }

////////////

//act42

public string[] palabras;

    void Start()
    {
        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i];
            if (StartsWithVowel(palabra))
            {
                Debug.Log("String encontrado: " + palabra);
                Debug.Log("Posicion en el array: " + i);
                break; 
            }
        }
    }

    bool StartsWithVowel(string palabra)
    {
        char letra = char.ToLower(palabra[0]);
        return letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u';
    }

///////////////

//act 43

public string[] words; // Array de strings

    void Start()
    {
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (StartsWithConsonant(word))
            {
                Debug.Log("String encontrado: " + word);
                Debug.Log("Posicion en el array: " + i);
                break; 
            }
        }
    }

    bool StartsWithConsonant(string word)
    {
        char firstChar = char.ToLower(word[0]); 
        return !IsVowel(firstChar); 

    bool IsVowel(char character)
    {
        character = char.ToLower(character);
        return character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u';
    }

///////////

//act44

    public string[] palabras;

    void Start()
    {
        for (int i = 0; i < palabras.Length; i++)
        {
            string palabra = palabras[i];
            Debug.Log("Valor: " + palabra);
            Debug.Log("Posicion en el array: " + i);
        }
    }

//////////

//act45

  public int[] numeros; 

    void Start()
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];
            if (numero % 2 == 0) 
            {
                Debug.Log("Numero par encontrado: " + numero);
            }
        }
    }

////////////////

//act 46

    public int[] numbers; 

    void Start()
    {
        int contar = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (number % 2 == 0) 
            {
                contar++;
            }
        }

        Debug.Log("La cantidad de numeros pares es: " + contar);
    }

//////////

//act 47

public int[] numeros; 

    void Start()
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            int numero = numeros[i];
            if (numero % 2 != 0) 
            {
                Debug.Log("Numero impar encontrado en la posicion " + i + ": " + numero);
            }
        }
    }

///////////

//act48

    public int[] numbers; 

    void Start()
    {
        int count = 0; 
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (number % 2 != 0) 
            {
                count++;
            }
        }

        Debug.Log("Cantidad de numeros impares: " + count);
    }

////////////

//act49

    public int[] numbers; 

    void Start()
    {
        int countPares = 0; 
        int countImpares = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = numbers[i];
            if (number % 2 == 0) 
            {
                countPares++;
            }
            else
            {
                countImpares++;
            }
        }

        Debug.Log("Cantidad de numeros pares: " + countPares);
        Debug.Log("Cantidad de numeros impares: " + countImpares);
    }

///////////

//act50

public float[] numbers; 

    void Start()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            float number = numbers[i];
            if (number > 0) 
            {
                Debug.Log("Numero positivo en la posicion " + i + ": " + number);
            }
        }
    }

///////////

//act51

    public float[] numbers; 

    void Start()
    {
        int positiveCount = 0; 
        int negativeCount = 0; 
        int zeroCount = 0; 

        for (int i = 0; i < numbers.Length; i++)
        {
            float number = numbers[i];

            if (number > 0)
            {
                positiveCount++;
            }
            else if (number < 0) 
            {
                negativeCount++;
            }
            else 
            {
                zeroCount++;
            }
        }

        Debug.Log("Elementos positivos: " + positiveCount);
        Debug.Log("Elementos negativos: " + negativeCount);
        Debug.Log("Elementos que valen 0: " + zeroCount);
    }

//////////////

//act52

    void Start()
    {
        int number = 0;

        while (number != 7)
        {
            number = Random.Range(1, 11);
            Debug.Log(number);
        }
        
        Debug.Log("Se ha generado el numero 7");
    }

////////////////

//act53

    void Start()
    {
        int year = 0;

        while (!IsLeapYear(year))
        {
            year = Random.Range(1, 2024);
            Debug.Log(year);
        }
        
        Debug.Log("Se ha generado un ano bisiesto");
    }

    bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }

/////////////

//act54

    void Start()
    {
        int number = 0;

        while (number % 5 != 0)
        {
            number = Random.Range(1, 1001);
            Debug.Log(number);
        }

        Debug.Log("Se ha generado el primer multiplo de 5");
    }

///////////

//act55

void Start()
    {
        int[] array = {2, 3, 4, 5};

        int product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }

        Debug.Log("El producto de los elementos del array es: " + product);
    }

/////////////////

//act56

void Start()
    {
        float[] array = {1.5f, 2.3f, 3.7f, 4.2f, 5.1f};

        float sum = 0f;

        for (int i = 0; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        Debug.Log("La suma de los elementos en posiciones pares es: " + sum);
    }

//////////////

//act57

    void Start()
    {
        float[] array = {1.5f, 2.3f, 3.7f, 4.2f, 5.1f}; 

        float sum = 0f;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += array[i];
            }
        }

        Debug.Log("La suma de los elementos en posiciones impares es: " + sum);
    }

///////////

//act58

    void Start()
    {
        float[] array = {1.5f, 2.3f, 3.7f, 4.2f, 5.1f}; 

        int sumPares = 0;
        int sumImpares = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumPares += (int)array[i];
            }
            else
            {
                sumImpares += (int)array[i];
            }
        }

        Debug.Log("La suma de los elementos en posiciones pares es: " + sumPares);
        Debug.Log("La suma de los elementos en posiciones impares es: " + sumImpares);
    }

////////////////

//act59

    public GameObject spherePrefab; // Prefab de la esfera

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            InstantiateSphere();
        }
    }

    void InstantiateSphere()
    {
        float x = Random.Range(-10f, 10f); 
        float y = Random.Range(0f, 5f); 
        float z = Random.Range(-10f, 10f); 

        Vector3 position = new Vector3(x, y, z); 

        Instantiate(spherePrefab, position, Quaternion.identity); 
    }

/////////////

//act60


}
