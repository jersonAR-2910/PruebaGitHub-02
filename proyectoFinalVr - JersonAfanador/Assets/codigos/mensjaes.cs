using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensjaes : MonoBehaviour
{
    // Start is called before the first frame update
    public void Mensaje1()
    {
        print("hola, este es el mensaje 1");
    }
    public void Mensaje2()
    {
        print("hola, este es el mensaje 2");

    }
    public void Mensaje3(string nombre)
    {
        print("hola" + nombre + "como estas");

    }
}
