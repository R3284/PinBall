


			
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
	Text scoreText;
	int score = 0;
	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;

	// Use this for initialization
	void Start () {
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");
		this.scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		//ボールが画面外に出た場合
		if (this.transform.position.z < this.visiblePosZ) {
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text> ().text = "Game Over";
		}
	}

	private void OnCollisionEnter (Collision collision)
	{
		string message = this.gameObject.name + " が " + collision.gameObject.name + " とぶつかった。タグは " + collision.gameObject.tag;
		Debug.Log (message);
		if (collision.gameObject.tag == "SmallStarTag") {
			score = score + 5;
			Debug.Log (score);
			scoreText.text = score.ToString ();

		}
		if (collision.gameObject.tag == "LargeStarTag") {
			score = score + 10;
			Debug.Log (score);
			scoreText.text = score.ToString ();
		
		}
		if (collision.gameObject.tag == "SmallCloudTag") {
			score = score + 10;
			Debug.Log (score);
			scoreText.text = score.ToString ();


		}
		if (collision.gameObject.tag == "LargeCloudTag") {
			score = score + 10;
			Debug.Log (score);
			scoreText.text = score.ToString ();
		}

	}
}	