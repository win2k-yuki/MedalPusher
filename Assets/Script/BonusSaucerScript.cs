using UnityEngine;
using System.Collections;
public class BonusSaucerScript : MonoBehaviour {
    public GameObject scoreText;
    public GameObject spawnLeft;
    public GameObject spawnRight;
    public GameObject coin3;
    public GameObject coin10;
    public GameObject cap100;
    public GameObject cap300;
    public GameObject coin1;
    ScoreScript scoreS;
    int dropflag = 0;
    // Use this for initialization
    void Start(){
        scoreS = scoreText.GetComponent<ScoreScript>();
    }
    void OnCollisionEnter(Collision colObjcet){
        if (colObjcet.gameObject.tag == "1coin"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(5);
            dropflag = 1;
        }
        if (colObjcet.gameObject.tag == "3coin"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(15);
            dropflag = 2;
        }
        if (colObjcet.gameObject.tag == "10coin"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(100);
            dropflag = 3;
        }
        if (colObjcet.gameObject.tag == "100cap"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(500);
            dropflag = 4;
        }
        if (colObjcet.gameObject.tag == "300cap"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(1500);
            dropflag = 5;
        }
    }
	// Update is called once per frame
	void Update () {
        if (dropflag == 0){
        }
        else if (dropflag == 1){
            dropflag = 0;
        }
        else if (dropflag == 2){
            dropflag = 0;
        }
        else if (dropflag == 3) {
            dropflag = 0;
        }
        else if (dropflag == 4) {
            dropflag = 0;
        }
        else if (dropflag == 5) {
            dropflag = 0;
        }
	}
//droptype おっきい方 300 小さい方1
    void InitBonusdrop(string droptype,int[] amount){
        int num16 = int.Parse(droptype, System.Globalization.NumberStyles.HexNumber);
        if (num16 / 16 == 1){
            num16 -= 16;
        }
        if (num16 / 8 == 1) {
            num16 -= 8;
        }
        if (num16 / 4 == 1) {
            num16 -= 4;
        }
        if (num16 / 2 == 1) {
            num16 -= 2;
        }
        if (num16 / 1 == 1) {
            num16 -= 1;
        }
    }
    //droptypeで落ちる奴決める
    //1桁目0 コイン 1桁目1 カプセル
    void drop(int droptype,int amount){

    }
}
