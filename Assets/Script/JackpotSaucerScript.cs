using UnityEngine;
using System.Collections;

public class JackpotSaucerScript : MonoBehaviour {
    public GameObject jtext;
    JackpotScript jackpot;
	// Use this for initialization
	void Start () {
        jackpot = jtext.GetComponent<JackpotScript>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision colobject) {
        Destroy(colobject.gameObject);
        jackpot.add(10);
    }
}
