using UnityEngine;
using TMPro;

public class Vpad : MonoBehaviour
{ 

    //usar textos del canvas
    public TextMeshProUGUI dirText, Tcount, value;


    //gestionar los eventos touch
    private Touch TC;
    //registrar la diferencia de las coordenadas
    //vector 2 representación de puntos en 2d, V3 usa en la posicion en 3d, v4 color
    private Vector2 StartP, EndP;
    //variable de estado de la direccion 
    private string direction; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0){

        //se carga el # de eventos
        //funciona con el primer dedo q haga contacto con la pantalla
        TC = Input.GetTouch(0);

      
        //Dependiendo de la fase se generan los eventos
        if(TC.phase == TouchPhase.Began){
            //Se establecen las coordenadas
            StartP = TC.position;
        } //si no se mueve
        else if(TC.phase == TouchPhase.Moved || TC.phase == TouchPhase.Ended)
        {

        //Obtener el vector final
        EndP = TC.position;
        //diferencia entre vectores
        float x = EndP.x - StartP.x;
        float y = EndP.y - StartP.y; 

        //Si no se esta moviendo x ni y
        if(Mathf.Abs(x)==0 && Mathf.Abs(y)==0){

            //la dirección no se registra movimiento
            direction = "Tapped";

        }//si se obtiene un movimiento q es mas grande x sobre y
        else if(Mathf.Abs(x) > Mathf.Abs(y)){

            direction = x > 0 ? "Right" : "Left";
        }
        else{

            direction = y > 0 ? "Up" : "Down";
        }

            value.SetText("x: " + (x/500).ToString() + " y: " + (y/500).ToString());
        }
        }

        
        dirText.SetText(direction);
        Tcount.SetText(Input.touchCount.ToString());
    }
}
