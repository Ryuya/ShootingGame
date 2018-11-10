using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    [SerializeField]
    private float time;

    public Text timeText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(time >= 0){
            time -= Time.deltaTime;
        } else{
            
        }

        timeText.text = time.ToString();
	}
}
