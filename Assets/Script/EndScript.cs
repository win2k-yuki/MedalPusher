using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EndScript : MonoBehaviour {
    Canvas EndObject;//終了UIのキャンバス
    public GameObject scoretext;//スコアテキストのゲームオブジェクト
    ScoreScript Score;//スコアテキストのスクリプト
    public Canvas InGameUI;//UI画面
    public Text GameoverLabel;//ゲームオーバー
    public Text EndScoreText;
    public Text RestartText;
    public Image RestartImage;
    public Button RestartButton;
    public Text EndText;
    public Button EndButton;
    public Image EndImage;
    int GameoverScore;//最終スコア

    LevelManager levelManager;
	// Use this for initialization
	void Start () {
       EndObject = this.GetComponent<Canvas>();
       InGameUI = InGameUI.GetComponent<Canvas>();
       Score = scoretext.GetComponent<ScoreScript>();
       levelManager = GameObject.Find("LevelMan").GetComponent<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("q")) {//デバッグ用
            GameOver();
            
        }
	}
    public void GameOver() {
        //UIの切り替え。元々あるものを非表示、終了UIを表示
        EndObject.enabled = true;
        InGameUI.enabled = false;
        GameoverScore = Score.currentScore;//最終スコア取得
        EndScoreText.text = "最終スコア:" + GameoverScore.ToString();
    }
    public void ReturnClick() {
        Application.LoadLevel("TitleScene");
    }
}
