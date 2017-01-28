using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlMovimientoPikuros : MonoBehaviour {

	
    GameObject controlador;
    public bool derecha = true; //si es true, se moveran a la derecha.

    [Header("NO TOCAR xd")]
    public bool bajarPikuros = false; //si es true, todos los pikuros bajaran un poco, pero luego volverá a FALSE.
    public bool bajarPosible = true;  //si es true, se puede bajar. Si es false, no se podrá bajar.

    GameObject[] pikuros;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void irDerecha()
    {
        derecha = true;
        bajar();
    }
    public void irIzquierda()
    {
        derecha = false;
        bajar();
    }

    public void bajar()
    {
        pikuros = GameObject.FindGameObjectsWithTag("pikuro");
        if (bajarPosible)
        {
            bajarPosible = false;
            bajarPikuros = true;
            StartCoroutine(esperar());
            for (int i = 0; i < pikuros.Length; i++)
            {
                pikuros[i].GetComponent<controladorMovimientoPikuros>().bajar();
            }
        }
    }

    IEnumerator esperar()
    {
        yield return new WaitForSeconds(0.5f);

        bajarPosible = true;
    }
}
