using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {
    public GameObject cyan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            cyan.gameObject.SetActive(true);
        } else {
            this.gameObject.SetActive(false);
        }
    }
}
