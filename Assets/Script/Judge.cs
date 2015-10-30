using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge : MonoBehaviour {
    public GameObject scoreScript;
    ScoreScript Score;
    LevelManager levelManager;
    bool check = false;
    Text JudgeText;
    string JudgeRank;
    Color JudgeColor;
    private AudioSource rankAA;
    private AudioSource rankA;
    private AudioSource rankBC;
    private AudioSource rankD;
    private AudioSource rankE;
	// Use this for initialization
	void Start () {
        AudioSource[] audioSources = this.GetComponents<AudioSource>();
        rankAA = audioSources[0];
        rankA = audioSources[1];
        rankBC = audioSources[2];
        rankD = audioSources[3];
        rankE = audioSources[4];
        Score = scoreScript.GetComponent<ScoreScript>();
        levelManager = GameObject.Find("LevelMan").GetComponent<LevelManager>();
        JudgeText = this.GetComponent<Text>();
        JudgeColor.a = 255f / 255f;
	}
	// Update is called once per frame
	void Update () {
        if (check == false && levelManager.Endthis ==true) {
            check = true;
            if (Score.currentScore > 6000) {
                JudgeRank = "AAA";
                JudgeColor.r = 240f / 255f;
                JudgeColor.g = 158f / 255f;
                JudgeColor.b = 171f / 255f;
                rankAA.PlayOneShot(rankAA.clip);
            }else if (Score.currentScore > 4500) {
                JudgeRank = "AA";
                JudgeColor.r = 240f / 255f;
                JudgeColor.g = 158f / 255f;
                JudgeColor.b = 171f / 255f;
                rankAA.PlayOneShot(rankAA.clip);
            }else if (Score.currentScore > 3000) {
                JudgeRank = "A";//ここまで金色
                //rgba( 255,215,0 , 1 )
                JudgeColor.r = 240f / 255f;
                JudgeColor.g = 158f / 255f;
                JudgeColor.b = 171f / 255f;
                rankA.PlayOneShot(rankA.clip);
            }else if (Score.currentScore > 2000) {
                JudgeRank = "B";
                //rgba( 220,20,60 , 1 )
                JudgeColor.r = 220f / 255f;
                JudgeColor.g = 20f / 255f;
                JudgeColor.b = 60f / 255f;
                rankBC.PlayOneShot(rankBC.clip);
            }else if (Score.currentScore > 1000) {
                JudgeRank = "C";
                JudgeColor.r = 154f / 255f;
                JudgeColor.g = 202f / 255f;
                JudgeColor.b = 64f / 255f;
                rankBC.PlayOneShot(rankBC.clip);
            }else if (Score.currentScore > 500) {
                JudgeRank = "D";
                JudgeColor.r = 136f / 255f;
                JudgeColor.g = 206f / 255f;
                JudgeColor.b = 216f / 255f;
                rankD.PlayOneShot(rankD.clip);
            }else if (Score.currentScore > 0) {
                JudgeRank = "E";
                JudgeColor.r = 158f / 255f;
                JudgeColor.g = 139f / 255f;
                JudgeColor.b = 192f/255f;
                rankE.PlayOneShot(rankE.clip);
            }
            JudgeText.text = JudgeRank;
            JudgeText.color = JudgeColor;
        }
	}
}
