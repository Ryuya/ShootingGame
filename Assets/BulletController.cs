using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    Rigidbody rb;

    private int attackpoint = 3;
	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.forward * 8);
	}

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Enemy"){
            other.gameObject.GetComponent<Enemy>().TakeDamage(this.attackpoint);
            Destroy(gameObject);
        }
	}
}
