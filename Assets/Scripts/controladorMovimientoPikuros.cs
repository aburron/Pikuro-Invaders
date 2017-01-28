using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorMovimientoPikuros : MonoBehaviour {

    GameObject controlador;
    Component controlMovi;

    public float transladoPorPulso = 1.0f;

    void Start () {
        controlador = GameObject.Find("CONTROLADOR");
        controlMovi = controlador.GetComponent<controlMovimientoPikuros>();
        //Esta corroutina la iniciará el generador de pikuros, cuando termine de generarlos.
        // StartCoroutine(mover());
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x > 8.7)  //Si algun pikuro sobrepasa el limite DERECHO, envia la orden de alternar.
        {
            controlador.GetComponent<controlMovimientoPikuros>().irIzquierda();
        }
        if (transform.position.x < -8.7)  //Si algun pikuro sobrepasa el limite IZQUIERDO, envia la orden de alternar.
        {
            controlador.GetComponent<controlMovimientoPikuros>().irDerecha();
        }


    }
    public void ejMover()   //Esto sirve para que se pueda ejecutar la corutina desde cualquier script
    {
        StartCoroutine(mover());
    }

    public void bajar() //Esta función la llama "controlMovimientoPikuros" y hace bajar el pikuro.
    {
            transform.Translate(new Vector2(0, -1));
    }

    IEnumerator mover()
    {
        yield return new WaitForSeconds(0.3f);
        

        if (controlador.GetComponent<controlMovimientoPikuros>().derecha == true)
        {
            this.transform.Translate(new Vector2(transladoPorPulso, 0));
        }else
        {
            this.transform.Translate(new Vector2(-transladoPorPulso, 0));
        }

        StartCoroutine(mover());
    }
}
