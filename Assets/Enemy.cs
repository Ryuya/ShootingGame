using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int HP = 10;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (HP <= 0)
        {
            Die();
        }

	}

    public void TakeDamage(int damage){
        this.HP -= damage;
    }

    public void Die(){
        Destroy(gameObject);
    }
}
