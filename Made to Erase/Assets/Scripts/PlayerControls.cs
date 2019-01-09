using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour {
    public float speed;
    public float jumpForce;
    public LayerMask groundLayers;
    public Text instructions;

    private SphereCollider col;
    private Rigidbody rb;
    private bool canMove;
    private bool jumping;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
        canMove = false;
        jumping = false;
	}

    void Update() {
        if (CanJump()) jumping = true;
        //toggle instructions
        if (Input.GetKeyDown(KeyCode.C)) instructions.gameObject.SetActive(!instructions.gameObject.activeSelf);
    }

    void FixedUpdate () {
        if (canMove)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector2 movement = new Vector3(moveHorizontal, 0.0f);
            rb.AddForce(movement * speed);
        }
        if (jumping) {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumping = false;
        }
    }

    bool CanJump()
    {
        return Physics.CheckCapsule(col.bounds.center,
            new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z),
            col.radius * .9f, groundLayers) && Input.GetKeyDown(KeyCode.Space);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnableControl"))
        {
            canMove = true;
            instructions.gameObject.SetActive(true);
        }
    }

}
