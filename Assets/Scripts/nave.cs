using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nave : MonoBehaviour {

    public float velocidad = 20.0f;
    public int vidas = 3;
    public bool mover = false;

    public GameObject controladorPikuros;
    public GameObject textoGameOver;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (mover)
        {
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 8.64f)
            {
                transform.Translate(new Vector2(velocidad, 0) * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -8.44f)
            {
                transform.Translate(new Vector2(-velocidad, 0) * Time.deltaTime);
            }
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "pikuro")
        {
            controladorPikuros.GetComponent<controlMovimientoPikuros>().parar();
            textoGameOver.SetActive(true);
            mover = false;
        }
    }
}
