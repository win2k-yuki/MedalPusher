using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
    float moveSpeed = 8.0f;
    Rigidbody rb;

    public GameObject coin;

    public GameObject Leftwall;
    public GameObject Rightwall;

    float leftbrockerPositionX;
    float rightbrockerPositionX;

    public GameObject scoreText;
    ScoreScript scoreS;

   	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        leftbrockerPositionX = Leftwall.transform.position.x;
        rightbrockerPositionX = Rightwall.transform.position.x;
        scoreS = scoreText.GetComponent<ScoreScript>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 currentPosition = this.transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x,
                                        leftbrockerPositionX,
                                        rightbrockerPositionX);
        this.transform.position = currentPosition;
        //キー入力
        float x = Input.GetAxis("Horizontal");
        //向き
        Vector3 direction = new Vector3(x, 0, 0);
        rb.velocity = direction * moveSpeed;
        if (Input.GetKeyDown("space"))
        {
            Instantiate(coin, this.transform.position, this.transform.rotation);
            scoreS.subScore(1);
        }
	}
}
