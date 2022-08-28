using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiC : MonoBehaviour
{

    //Texto donde se muestran los mensajes
    public TextMeshProUGUI texto;
    private int TapCount = 0;
    private string Mtinfo;
    private Touch theTouch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Imprimimos la cantidad de dedos
        Mtinfo = string.Format("Número dedos: {0}\n", TapCount);


        //Se registran los eventos 
        if(Input.touchCount > 0){
            
            //Recorre cada uno de los eventos touch
            for(int i = 0; i < Input.touchCount; i++){
                theTouch = Input.GetTouch(i);
                string info = "Touch: " + i.ToString() + " - " + theTouch.phase.ToString() + "/n"; 
                
                //Otra forma
                //theTouch.tapCount.ToString() + 
                //" - " + "finger id: " + theTouch.fingerId.ToString() + " - " + "nRadius " +
                //    theTouch.radius.ToString();     

                Mtinfo += info;
            }

        }

        //se iguala para q muestre cuantos dedos se tienen en pantalla
        TapCount = Input.touchCount;
        texto.SetText(Mtinfo);
        
    }
}
