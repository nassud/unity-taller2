using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TouchC : MonoBehaviour
{

    //Texto donde se muestran los mensajes
    public TextMeshProUGUI texto;
    private Touch theTouch;
    private float TouchTime, displayTime = 0.5f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gestiona las entradas que podemos llegar a tener
        //Mientras se tenga mas de un dedo tocando la pantalla
        if(Input.touchCount > 0){
            //se referencia al primer dedo q tok la pantalla arroja la lista de eventos que esta tocando
            theTouch = Input.GetTouch(0);
            //muestra la fase en la cual se encuentran estos eventos touch (en el momento de gestionarlos)
            texto.SetText(theTouch.phase.ToString());
            //limpiar la pantalla
            //estado ende cuando se levanta el dedo de la pantalla
            if(theTouch.phase == TouchPhase.Ended){
                //Se cuenta el tiempo
                TouchTime = Time.time;
            }
        }
        //Mientras no este tocando
        //tiempo q acumula entre cuadros y tiempo q esta establecido como touch
        else if(Time.time - TouchTime > displayTime){
            //cambia el texto a vacio
            texto.SetText(" ");
        }
        
    }
}
