using UnityEngine;
using System.Collections;
public class BonusSaucerScript : MonoBehaviour {
    public GameObject scoreText;
    public GameObject bonusSpawner;
    public GameObject bonusLevelText;
    BonusSpawnerScript bonusSpawn;
    ScoreScript scoreS;
    BonusChanceScript bonuschance;
    private AudioSource PlaySE;
    public GameObject TimeText;
    TimeScript timeScript;
    int dropflag = 0;
    // Use this for initialization
    void Start(){
        PlaySE = this.GetComponent<AudioSource>();
        scoreS = scoreText.GetComponent<ScoreScript>();
        bonusSpawn = bonusSpawner.GetComponent<BonusSpawnerScript>();
        bonuschance = bonusLevelText.GetComponent<BonusChanceScript>();
        timeScript = TimeText.GetComponent<TimeScript>();
    }
    void OnCollisionEnter(Collision colObjcet){
        PlaySE.Stop();
        PlaySE.PlayOneShot(PlaySE.clip);
        
//        Debug.Log(bonuschance);
        if (colObjcet.gameObject.tag == "1coin"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(5);
            bonuschance.addLevel(1);
            dropflag = 1;
            timeScript.currentTime += 0.2f;
        }
        if (colObjcet.gameObject.tag == "3coin"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(15);
            bonuschance.addLevel(1);
            dropflag = 2;
            timeScript.currentTime += 1f;
        }
        if (colObjcet.gameObject.tag == "10coin"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(50);
            bonuschance.addLevel(1);
            dropflag = 3;
            timeScript.currentTime += 2f;
        }
        if (colObjcet.gameObject.tag == "100cap"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(500);
            bonuschance.addLevel(1);
            dropflag = 4;
            timeScript.currentTime += 3f;
        }
        if (colObjcet.gameObject.tag == "300cap"){
            Destroy(colObjcet.gameObject);
            scoreS.addScore(1500);
            bonuschance.addLevel(1);
            dropflag = 5;
            timeScript.currentTime += 5f;
        }
    }
	// Update is called once per frame
    //dropamountは0よりは大きい、4よりは小さい
	void Update () {
        if (dropflag == 0){
            
        }
        else if (dropflag == 1){//銀コ
            dropflag = 0;
            int[] dropamount = {0,0,0,2,2};
            bonusSpawn.InitBonusdrop("11",dropamount);
        }
        else if (dropflag == 2){//赤コ
            dropflag = 0;
            int[] dropamount = {0,0,2,2,2 };
            bonusSpawn.InitBonusdrop("111", dropamount);
            
        }
        else if (dropflag == 3) {//金コ
            dropflag = 0;
            int[] dropamount = {0,1,2,2,4 };
            bonusSpawn.InitBonusdrop("1110", dropamount);
        }
        else if (dropflag == 4) {//黒カプ
            dropflag = 0;
            int[] dropamount = {1,0,2,4,5 };
            bonusSpawn.InitBonusdrop("11100", dropamount);
        }
        else if (dropflag == 5) {
            dropflag = 0;
            int[] dropamount = { 0, 0, 10 ,20, 30 };
            bonusSpawn.InitBonusdrop("00111", dropamount);
            dropflag = 0;
        }
        
	}
}
