using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public int velocidad = 10;
	// Use this for initialization
	void Start () {
        StartCoroutine(borrar());
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up*velocidad*Time.deltaTime);
	}

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "pikuro")
        {
            Destroy(this.gameObject);
            Destroy(coll.gameObject);
        }
        print(coll.transform.name);
    }

    IEnumerator borrar()
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }
}
