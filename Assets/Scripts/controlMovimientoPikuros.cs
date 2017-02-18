using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlMovimientoPikuros : MonoBehaviour {

	
    GameObject controlador;
    public bool mover = false;
    public bool derecha = true; //si es true, se moveran a la derecha.

    public bool bajarPikuros = false; //si es true, todos los pikuros bajaran un poco, pero luego volverá a FALSE.
    bool bajarPosible = true;  //si es true, se puede bajar. Si es false, no se podrá bajar.

    public GameObject[] pikuross = new GameObject[70];

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            mover = true;
        }
        cargar();

    }

    public void cargar()
    {
        pikuross = GameObject.FindGameObjectsWithTag("pikuro");
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
        if (bajarPosible)
        {
            bajarPosible = false;
            bajarPikuros = true;
            StartCoroutine(esperar());


            for (int i = 0; i < 70; i++)
            {
                print(pikuross[i]);
                pikuross[i].transform.Translate(new Vector2(0, -1));
            }
        }
    }

    IEnumerator esperar()
    {
        yield return new WaitForSeconds(0.5f);

        bajarPosible = true;
        bajarPikuros = false;
    }
}
