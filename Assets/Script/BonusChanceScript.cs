using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BonusChanceScript : MonoBehaviour {
    public GameObject Bonusgauge;
    public GameObject Lotterytext;
    LotteryScript Lottery;
    public int InitLevel;
    Slider bonusValue;
    int currentLevel;
    Text Bonusleveltext;
    public bool addtrue=true;
	// Use this for initialization
	void Start () {
        Bonusleveltext = this.GetComponent<Text>();
        bonusValue = Bonusgauge.GetComponent<Slider>();
        Lottery = Lotterytext.GetComponent<LotteryScript>();
        currentLevel = InitLevel;
        printBonusLevel(currentLevel);
	}
	
	// Update is called once per frame
	void Update () {
        if (currentLevel >= 10) {
            Lottery.LotStart();
            currentLevel = 0;
            addtrue = false;
        }
       // Debug.Log(addtrue);
	}
    public void addLevel(int n){
        
        if (addtrue == true) {
            currentLevel += n;
            printBonusLevel(currentLevel);
        }
        
    }
    public void setLevel(int n) {
        currentLevel = n;
        printBonusLevel(currentLevel);

    }
    void printBonusLevel(int n) {
        Bonusleveltext.text = n.ToString() + "/" + bonusValue.maxValue.ToString();
        bonusValue.value = n;
        
    }
}
