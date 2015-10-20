using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
    private AudioSource se;
	// Use this for initialization
	void Start () {
        se = this.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnClick(){
        se.PlayOneShot(se.clip);
        Application.LoadLevel("MainScene");
    }
}
