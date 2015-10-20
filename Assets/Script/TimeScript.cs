using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
    public float initTime;
    public float currentTime;
    Text timeText;
	// Use this for initialization
	void Start () {
        currentTime = initTime;
        timeText = this.GetComponent<Text>();
        printTime((int)currentTime);
	}
	
	// Update is called once per frame
	void Update () {
        currentTime -= Time.deltaTime;
        if (currentTime < 0) currentTime = 0;
        printTime((int)currentTime);
        if (currentTime == 0) {
            currentTime = -1;
        }
	}
    void printTime(int n){
        timeText.text = "Time:"+n.ToString();
    }
}
