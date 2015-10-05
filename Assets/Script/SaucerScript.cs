using UnityEngine;
using System.Collections;

public class SaucerScript : MonoBehaviour {
    public GameObject scoreText;
    ScoreScript scoreS;
	// Use this for initialization
	void Start () {
        scoreS = scoreText.GetComponent<ScoreScript>();
	}
    void OnCollisionEnter(Collision colObjcet){
        if (colObjcet.gameObject.tag == "1coin"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(1);
        }
        if (colObjcet.gameObject.tag == "3coin")
        {
            Destroy(colObjcet.gameObject);
            scoreS.addScore(3);
        }
        if (colObjcet.gameObject.tag == "10coin")
        {
            Destroy(colObjcet.gameObject);
            scoreS.addScore(10);
        }
        if (colObjcet.gameObject.tag == "100cap")
        {
            Destroy(colObjcet.gameObject);
            scoreS.addScore(100);
        }
        if (colObjcet.gameObject.tag == "300cap")
        {
            Destroy(colObjcet.gameObject);
            scoreS.addScore(300);
        }
        
    }
	// Update is called once per frame
	void Update () {
	
	}
}
