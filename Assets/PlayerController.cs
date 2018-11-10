using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Use this for initialization
    public GameObject bullet_prefab;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(h,0,v);

        //スペースキーが押されたなら
        if(Input.GetKeyDown(KeyCode.Space)){
            Shot();
        }
	}

    public void Shot(){
        GameObject go = Instantiate(bullet_prefab);
        go.transform.position = this.transform.position;
    }
}
