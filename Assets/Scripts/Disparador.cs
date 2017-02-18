using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour {

    public float velDisparo;
    float temporizador; // Cuenta el tiempo desde el ultimo disparo.
    public GameObject bala;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            if (temporizador >= velDisparo)
            {
                Instantiate(bala, transform.position, Quaternion.identity);
                temporizador = 0;
            }
        }

        temporizador += 1 * Time.deltaTime;
	}
}
