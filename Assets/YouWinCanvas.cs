using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivingRoomCanvas : MonoBehaviour {

public Button LR_FryButton;
public Button LR_KylieButton;
public Button LR_PterodactylKim;
public Button LR_Kim2Krying;
public Button LR_Kanye;
public GameObject LR_Kim2KryingGO;
public GameObject LR_PterodactylKimGO;
public GameObject LR_KanyeGO;
public GameObject LR_KylieGO;
public GameObject LR_FryGO;

//public var ScoreWord : UI.Text;
public Text ScoreText;
private int NumScore;
private AudioSource TrapQueen;


	// Use this for initialization
	void Start () {
		PlayWinningSong();
	}
	
	// Update is called once per frame
	void Update () {
	}

public void IncreaseScore () {
	NumScore = NumScore + 10;
	ScoreText.text = NumScore.ToString ();
 }

 public void SpecialPointScore () {
 	NumScore = NumScore + 1488;
 	ScoreText.text = NumScore.ToString ();
 }

 public void PlayWinningSong () {
 	TrapQueen = GetComponent<AudioSource>();
 	TrapQueen.time = 17;
 	TrapQueen.Play();
 }
}