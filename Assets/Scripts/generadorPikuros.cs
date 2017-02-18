using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorPikuros : MonoBehaviour {

	public GameObject pikuroTypeA, pikuroTypeB, pikuroTypeC;
    public int columnas = 11, filas = 6;
    public float tiempoAparecer = 0.06f;
    [Header("Configuración de la posicion")]
    public float offsetX = -10.0f, offsetY = +5.0f;
    public float separacionX = 1.8f, separacionY = 1.49f;

    public GameObject[] pikuross = new GameObject[70];

	void Start () {
        StartCoroutine(startGenerar());
	}


	void Update () {
		
	}

    IEnumerator startGenerar()
    {
        for(int iY = 0; iY < filas; iY++)
        {
            for(int iX = 0; iX < columnas; iX++)
             {
                 generar(new Vector2((iX - offsetX) / separacionX, (iY *-1.5f + offsetY) / separacionY));
                 yield return new WaitForSeconds(tiempoAparecer);
             }
        }

        print("Done!");        
    }

    int generados = 0;
    void generar(Vector2 vectorAGenerar)
    {
        Vector2 posicion = vectorAGenerar;  //Me gusta pasar la variable de la función a otra variable XD.

        print("generado pikuro en: " + posicion);
        GameObject go = Instantiate(pikuroTypeA, posicion, Quaternion.identity) as GameObject;

        pikuross[generados] = go;
        generados ++;
    }
}
