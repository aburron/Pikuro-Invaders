using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorMovimientoPikuros : MonoBehaviour {

    GameObject controlador;

    public float transladoPorPulso = 1.3f;
    public float bajadaPorPulso = 1.0f;     //En controlmovimiento ya se edita manualmente.

    void Start () {
        controlador = GameObject.Find("CONTROLADOR");
        StartCoroutine(mover());
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x > 8.7)  //Si algun pikuro sobrepasa el limite DERECHO, envia la orden de alternar.
        {
            controlador.GetComponent<controlMovimientoPikuros>().irIzquierda();
            controlador.GetComponent<controlMovimientoPikuros>().bajar();
        }
        if (transform.position.x < -8)  //Si algun pikuro sobrepasa el limite IZQUIERDO, envia la orden de alternar.
        {
            controlador.GetComponent<controlMovimientoPikuros>().irDerecha();
            controlador.GetComponent<controlMovimientoPikuros>().bajar();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(mover());
        }

        if (controlador.GetComponent<controlMovimientoPikuros>().bajarPikuros == true)
        {
            //  this.transform.Translate(new Vector2(0, -bajadaPorPulso));
        }
    }

    IEnumerator mover()
    {
        yield return new WaitForSeconds(1f);
        if (controlador.GetComponent<controlMovimientoPikuros>().mover == true)
        {
            if (controlador.GetComponent<controlMovimientoPikuros>().derecha == true)
            {
                this.transform.Translate(new Vector2(transladoPorPulso, 0));
            }
            else
            {
                this.transform.Translate(new Vector2(-transladoPorPulso, 0));
            }

            StartCoroutine(mover());
        }
    }
}
