using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour {
    public GameObject player;

    private Text dialogue;
    private Queue<string> fuchsiaLines;
    private Queue<string> cyanLines;
    private int count;

    // Use this for initialization
    void Start() {
        this.count = 0;
        this.dialogue = GetComponent<Text>();
        this.fuchsiaLines = new Queue<string>();
        this.cyanLines = new Queue<string>();
        this.readDialogues(this.cyanLines, "Assets/Story/cyan.txt");
        this.readDialogues(this.fuchsiaLines, "Assets/Story/fuchsia.txt");
    }

    // Update is called once per frame
    void Update() {
        //Check if the player has moved to a position that should have a different text display
        if ((count < 1 && player.transform.position.y < 2 && player.transform.position.x != 0) ||
            (count < 2 && player.transform.position.x > 20) ||
            (count < 3 && player.transform.position.x > 40) ||
            (count < 4 && player.transform.position.x > 55) ||
            (count < 5 && player.transform.position.x > 70) ||
            (count < 6 && player.transform.position.x > 95) ||
            (count < 7 && player.transform.position.x > 125 && player.transform.position.y > 35) ||
            (count < 8 && player.transform.position.x > 155 && player.transform.position.y > 42) ||
            (count < 9 && player.transform.position.x > 175 && player.transform.position.y > 45) ||
            (count < 10 && player.transform.position.x > 195 && player.transform.position.y > 32) ||
            (count < 11 && player.transform.position.x > 230) ||
            (count < 12 && player.transform.position.x > 275) ||
            (count < 13 && player.transform.position.x > 298) ||
            (count < 14 && player.transform.position.x > 330) ||
            (count < 15 && player.transform.position.x > 334 && player.transform.position.y < 54)) {
            changeText();
        }
    }

    void changeText() {
        if(this.count % 2 == 0) {
            //It's Fuchsia's turn to speak
            this.dialogue.color = new Color(1f, 0.3921569f, 0.6705883f, 1f);
            this.dialogue.text = fuchsiaLines.Dequeue();
        } else {
            //It's Cyan's turn to speak
            this.dialogue.color = new Color(0.124822f, 0.8018868f, 0.7813679f, 1f);
            this.dialogue.text = cyanLines.Dequeue();
        }
        this.count++;
    }

    //Put lines of the story from a text file into a queue
    void readDialogues(Queue<string> q, string fileName) {
        string line;
        System.IO.StreamReader file = new System.IO.StreamReader(@fileName);
        while ((line = file.ReadLine()) != null) {
            q.Enqueue(line);
        }
        file.Close();
        // Suspend the screen.  
        System.Console.ReadLine();
    }
}
