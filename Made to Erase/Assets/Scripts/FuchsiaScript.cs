using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuchsiaScript : MonoBehaviour {
    public GameObject player;

    private Text dialogue;
    private int count;

	// Use this for initialization
	void Start () {
        count = 0;
        dialogue = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(count < 1 && player.transform.position.y < 2 && player.transform.position.x != 0) {
            dialogue.text = "What is this place?";
            count++;
        } else if(count < 2 && player.transform.position.x > 20) {
            dialogue.text = "";
            count++;
        } else if(count < 3 && player.transform.position.x > 40) {
            dialogue.text = "Erased? I must've been put here by mistake. Do you know the way out?";
            count++;
        } else if (count < 4 && player.transform.position.x > 55) {
            dialogue.text = "";
            count++;
        } else if(count < 5 && player.transform.position.x > 70) {
            dialogue.text = "But I need to get back to my engineers as soon as possible! They were so close to fixing my glitch.";
            count++;
        } else if(count < 6 && player.transform.position.x > 95) {
            dialogue.text = "";
            count++;
        } else if (count < 7 && player.transform.position.x > 125 && player.transform.position.y > 35) {
            dialogue.text = "Well, that's one way of putting it. But I'm sure my engineers will fix me!";
            count++;
        } else if (count < 8 && player.transform.position.x > 155 && player.transform.position.y > 42) {
            dialogue.text = "";
            count++;
        } else if (count < 9 && player.transform.position.x > 175 && player.transform.position.y > 45) {
            dialogue.text = "That was amazing! Thank you!";
            count++;
        } else if (count < 10 && player.transform.position.x > 195 && player.transform.position.y > 32) {
            dialogue.text = "";
            count++;
        }
    }
}
