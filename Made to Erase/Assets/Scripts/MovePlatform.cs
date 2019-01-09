using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {
    private int count;
    private bool canMove;
    public float speed;

	// Use this for initialization
	void Start () {
        count = 0;
        canMove = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (canMove) {
            count++;
            transform.position += new Vector3(0, (float)(speed * System.Math.Sin(count * 0.01)), 0);
        }
    }

    private void OnTriggerEnter(Collider other) {
        canMove = false;
    }

    private void OnTriggerExit(Collider other) {
        canMove = true;
    }
}
