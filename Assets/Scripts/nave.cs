using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour {

    public float velocidad = 20.0f;
    public int vidas = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(velocidad ,0)*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-velocidad, 0) * Time.deltaTime);
        }
    }
}
