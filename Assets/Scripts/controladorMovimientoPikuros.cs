using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorMovimientoPikuros : MonoBehaviour {

    GameObject controlador;

    public float transladoPorPulso = 1.0f;

    void Start () {
        controlador = GameObject.Find("CONTROLADOR");
        StartCoroutine(mover());
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x > 8.7)  //Si algun pikuro sobrepasa el limite DERECHO, envia la orden de alternar.
        {

        }
        if (transform.position.x < -8.7)  //Si algun pikuro sobrepasa el limite IZQUIERDO, envia la orden de alternar.
        {

        }
    }

    IEnumerator mover()
    {
        yield return new WaitForSeconds(0.2f);
        if(controlador.GetComponent<controlMovimientoPikuros>().derecha == true)
        {
            this.transform.Translate(new Vector2(transladoPorPulso, 0));
        }else
        {
            this.transform.Translate(new Vector2(-transladoPorPulso, 0));
        }

        StartCoroutine(mover());
    }
}
