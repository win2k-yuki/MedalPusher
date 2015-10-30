using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BonusText : MonoBehaviour {
    public GameObject bss;
    LotteryScript bonusSpawner;
    string GetBonusAmount;
    Text bonusTextAnnounce;
    void Start() {
        bonusSpawner = bss.GetComponent<LotteryScript>();
        bonusTextAnnounce = this.GetComponent<Text>();
    }
	// Update is called once per frame
	public virtual void Update () {
        if (bonusSpawner.BonusTextActivate == true) {
            bonusSpawner.BonusTextActivate = false;
            StartCoroutine(DispBonusText());
        }
	}
    IEnumerator DispBonusText() {
        GetBonusAmount = bonusSpawner.dropamount.ToString();
        bonusTextAnnounce.text = "Get Bonus Coin\n" + GetBonusAmount;
        bonusTextAnnounce.enabled = true;
        yield return new WaitForSeconds(5f);
        bonusTextAnnounce.enabled = false;
    }
}
