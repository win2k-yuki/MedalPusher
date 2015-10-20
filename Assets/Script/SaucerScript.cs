using UnityEngine;
using System.Collections;

public class SaucerScript : MonoBehaviour {
    public GameObject scoreText;
    ScoreScript scoreS;
    private AudioSource PlaySe;
   // private AudioClip getcoin;
	// Use this for initialization
	void Start () {
        scoreS = scoreText.GetComponent<ScoreScript>();
        PlaySe = this.GetComponent<AudioSource>();
      //  getcoin = this.GetComponent<AudioClip>();
	}
    void OnCollisionEnter(Collision colObjcet){
        PlaySe.Stop();

        PlaySe.PlayOneShot(PlaySe.clip);
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
