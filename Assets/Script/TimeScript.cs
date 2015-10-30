using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
    public float initTime;
    public float currentTime;
    LevelManager levelManager;
    Text timeText;
	// Use this for initialization
	void Start () {
        currentTime = initTime;
        timeText = this.GetComponent<Text>();
        levelManager = GameObject.Find("LevelMan").GetComponent<LevelManager>();
        printTime((int)currentTime);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0) {
            currentTime = 0;
            levelManager.Endthis = true;
        }
        printTime((int)currentTime);
        
	}
    void printTime(int n){
        timeText.text = "Time:"+n.ToString();
    }
}
