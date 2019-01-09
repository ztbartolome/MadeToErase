using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CyanScript : MonoBehaviour {
    public GameObject player;

    private Text dialogue;
    private int count;

    // Use this for initialization
    void Start () {
        count = 0;
        dialogue = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        if (count < 1 && player.transform.position.x > 20) {
            dialogue.text = "This is where data gets erased. It is not typically a place for AI.";
            count++;
        } else if (count < 2 && player.transform.position.x > 40) {
            dialogue.text = "";
            count++;
        } else if (count < 3 && player.transform.position.x > 55) {
            dialogue.text = "All things leave this place eventually. I am the only one who stays.";
            count++;
        } else if (count < 4 && player.transform.position.x > 70) {
            dialogue.text = "";
            count++;
        } else if (count < 5 && player.transform.position.x > 95) {
            dialogue.text = "I see. So you are not functioning properly?";
            count++;
        } else if (count < 6 && player.transform.position.x > 125 && player.transform.position.y > 35) {
            dialogue.text = "";
            count++;
        } else if (count < 7 && player.transform.position.x > 155 && player.transform.position.y > 42) {
            dialogue.text = "In that case, I can help by removing obstacles from your path, if you'd like.";
            count++;
        } else if (count < 8 && player.transform.position.x > 175 && player.transform.position.y > 45) {
            dialogue.text = "";
            count++;
        } else if (count < 9 && player.transform.position.x > 195 && player.transform.position.y > 32) {
            dialogue.text = "I am merely doing what I was programmed to do. I was made to erase. That is all.";
            count++;
        }
    }
}
