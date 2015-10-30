using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    public bool Endthis;//ゲームオーバーのパラメータ。trueで終了。原則falseと設定
    bool EndthisPlayed = false;
    EndScript endScript;
	// Use this for initialization
	void Start () {
        endScript = GameObject.Find("GameOverUI").GetComponent<EndScript>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (EndthisPlayed == false && Endthis == true) {
            endScript.GameOver();
            EndthisPlayed = true;
        }
	}
}
