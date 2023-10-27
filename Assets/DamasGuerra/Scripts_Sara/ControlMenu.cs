using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;  este era el error por el que no funcionaba el script.
using UnityEngine;
using MoreMountains.Tools; //importé otra clase para saber donde esta ubicada la carpeta.

public class ControlMenu : MonoBehaviour
{

    //primera clase y primer método
    public void OnJugar() //On es una acción que responde a una interfaz gráfica (al presionar el botón comienza el juego). 
    {
        Debug.Log("Ir a Jugar"); //objeto debug, propiedad log, con esto imprimo (velocidad, vida, etc.)
        MMSceneLoadingManager.LoadScene("Nivel1"); //estoy diciendo que se cargue la escena al apretar el botón.
        //hace parte del TopDownEngine de Unity. 
    }

    public void OnInstrucciones() //On es una acción que responde a una interfaz gráfica (al presionar el botón comienza el juego). 
    {
        Debug.Log("Ir a Instrucciones"); //objeto debug, propiedad log, con esto imprimo (velocidad, vida, etc.)
        MMSceneLoadingManager.LoadScene("Instrucciones"); //estoy diciendo que se cargue la escena al apretar el botón.
        //hace parte del TopDownEngine de Unity. 
    }

    public void OnCreditos() //On es una acción que responde a una interfaz gráfica (al presionar el botón comienza el juego). 
    {
        Debug.Log("Ir a Creditos"); //objeto debug, propiedad log, con esto imprimo (velocidad, vida, etc.)
        MMSceneLoadingManager.LoadScene("Creditos"); //estoy diciendo que se cargue la escena al apretar el botón.
        //hace parte del TopDownEngine de Unity. 
    }

    public void OnInicio() //On es una acción que responde a una interfaz gráfica (al presionar el botón comienza el juego). 
    {
        Debug.Log("Volver"); //objeto debug, propiedad log, con esto imprimo (velocidad, vida, etc.)
        MMSceneLoadingManager.LoadScene("Inicio"); //estoy diciendo que se cargue la escena al apretar el botón.
        //hace parte del TopDownEngine de Unity. 
    }
}
