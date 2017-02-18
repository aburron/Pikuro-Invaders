using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsShowTitle : MonoBehaviour {

    public float tiempoDeEspera;    //Esto es lo que tardará en aparecer los objetos.
    public GameObject[] objetos;    //Aquí se especificarán los objetos que van a aparecer poco a poco.

	void Start () {
        for(int i = 0; i<objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
        StartCoroutine(show());
    }
	
	public IEnumerator show()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            yield return new WaitForSeconds(tiempoDeEspera);
            objetos[i].SetActive(true);
        }        
    }
}
