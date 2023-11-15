using System.Collections;
using System.Collections.Generic;
using MoreMountains.TopDownEngine;
using TMPro;
using UnityEngine;
using MoreMountains.Tools;


//script para actualizar las vidas 
public class ContadorVidas : MonoBehaviour
{
    [SerializeField]
    private TMP_Text contador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //mayor que 0 sigue contando vidas sino, se acaba el juego
    void Update()
    {
        if (GameManager.Instance.CurrentLives <0 )
        {
            contador.SetText(GameManager.Instance.CurrentLives.ToString());
        }
        else
        {
            //MMGameEvent.trigger("JuegoTerminado");
            MMSceneLoadingManager.LoadScene("Perdio");
        }
        
    }
}
