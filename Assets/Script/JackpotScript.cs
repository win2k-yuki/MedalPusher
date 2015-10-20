using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JackpotScript : MonoBehaviour {
    public int InitJackpot;
    public int currentJackpot;
    Text JackpotText;
	// Use this for initialization
	void Start () {
        JackpotText = this.GetComponent<Text>();
        currentJackpot = InitJackpot;
        print(currentJackpot);
    }

    // Update is called once per frame
    void Update() {

    }
    public void add(int n) {
        currentJackpot += n;
        print(currentJackpot);

    }
    public void set(int n) {
        currentJackpot = n;
        print(currentJackpot);

    }
    void print(int n) {
        JackpotText.text = "JACKPOT\n"+n.ToString();
    }
}
