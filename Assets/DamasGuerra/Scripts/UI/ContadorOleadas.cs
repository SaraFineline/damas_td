using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class ContadorOleadas : MonoBehaviour, MMEventListener<MMGameEvent>
{
    [SerializeField]
    private TMP_Text text; 
    //si se produce el evento de la nueva ola 
    public void OnMMEvent(MMGameEvent eventType)
    {
        if (eventType.EventName=="NuevaOla")
        {
            int olaActual = Oleadas.Instance.OlaActual; 
            int cantidadOlas = Oleadas.Instance.CantidadOlas();

            texto.text = "Ola" + ola_actual + "/" + cantidad_olas; 
        }
    }

    void OnEnable ()
    {
        this.EventStartListening<MMGameEvent>();
    }

    void onDisable () 
    {
        this.EventStoptListening<MMGameEvent>();
    }
}
