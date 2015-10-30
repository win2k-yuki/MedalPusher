using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class LotteryScript : MonoBehaviour {
    Text LotText;
    public GameObject JackpotText;
    JackpotScript Jackpot;
    public GameObject BonusChanceText;
    public GameObject Spawner;
    
    BonusSpawnerScript BonusSpawner;
    BonusChanceScript BonusChance;
    string[] Allow = new string[5];
    int AllowPosition = 0;
     public int lotselect = 0;
    int PositionRandom = 0;
    public int dropamount = 0;
    private bool IsJackpot = false;
    public bool BonusTextActivate = false;
	// Use this for initialization
	void Start () {
        LotText = this.GetComponent<Text>();
        Jackpot = JackpotText.GetComponent<JackpotScript>();
        BonusChance = BonusChanceText.GetComponent<BonusChanceScript>();
        BonusSpawner = Spawner.GetComponent<BonusSpawnerScript>();
	}
	
	// Update is called once per frame
	void Update () {
        if (BonusSpawner.Dropnow == true) { Print(0); }
	}
    public void LotStart() {
        /*
         * 確立じゃ
         * 10   600 0
         * 30   200 1
         * 50   100 2
         * 100  80  3
         * JP   20  4
         * ALL  1000
        */
        PositionRandom = Random.Range(0, 999);
        if (PositionRandom < 360) {//36
            lotselect = 0;
            dropamount = 10;
        }
        else if (PositionRandom < 620) {//26
            lotselect = 1;
            dropamount = 30;
        }
        else if (PositionRandom < 800) {//18
            lotselect = 2;
            dropamount = 50;
        }
        else if (PositionRandom < 950) {//15
            lotselect = 3;
            dropamount = 100;
        }
        else if (PositionRandom < 1000) {//5
            lotselect = 4;
            dropamount = Jackpot.currentJackpot;
            IsJackpot = true;
        }
        StartCoroutine(slot(lotselect));
    }
    void Print(int n) {
        for (int i = 0; i < 5; i++) {
            if (i == n) {
                Allow[i] = "→";
            }
            else {
                Allow[i] = "";
            }
        }
        LotText.text = Allow[0] + "10\n" + Allow[1] + "30\n" + Allow[2] + "50\n" + Allow[3] + "100\n" + Allow[4] + Jackpot.currentJackpot.ToString();
        if (IsJackpot == true) LotText.text = Allow[0] + "10\n" + Allow[1] + "30\n" + Allow[2] + "50\n" + Allow[3] + "100\n" + Allow[4] + dropamount;
    }
    //上から01234 回転数は30でOK
    IEnumerator slot(int n) {
        AllowPosition = 0;
        for (int i = 0; i <= 100 + n; i++) {
            
            Print(AllowPosition);
            yield return new WaitForSeconds(0.05f);
            if (i > 60) { yield return new WaitForSeconds(0.05f); }
            if (i > 100) { yield return new WaitForSeconds(0.05f); }
            AllowPosition++;
            if (AllowPosition > 4) {
                AllowPosition = 0;
            }
        }
        yield return new WaitForSeconds(1.5f);
        StartCoroutine (BonusSpawner.drop(10, dropamount));

        BonusChance.addtrue = true;
        BonusTextActivate = true;
        BonusChance.bonusValue.maxValue += 2;
    }
}
