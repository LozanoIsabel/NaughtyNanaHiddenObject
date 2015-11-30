using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonManagerCs : MonoBehaviour {

public Button FryButton;
public Button KylieButton;
public Button KryingKimButton;
public Button StartButton;
public Button PterodactylKim;
public Button Kim2Krying;
public Button Kanye;
public GameObject Kim2KryingGO;
public GameObject PterodactylKimGO;
public GameObject KanyeGO;
public GameObject KylieGO;
public GameObject KryingKimGO;
public GameObject FryGO;

//public var ScoreWord : UI.Text;
public Text ScoreText;
private int NumScore;
private AudioSource HotlineBling;
private AudioSource TrapQueen;


	// Use this for initialization
	void Start () {
		PlaySong();
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

 public void PlaySong () {
 	HotlineBling = GetComponent<AudioSource>();
 	HotlineBling.time = 33;
 	HotlineBling.Play();
 }

public void Living () {

//if(!LR_Kim2KryingGO.isActive && !LR_PterodactylKimGO.isActive && !LR_KanyeGO.isActive && !LR_KylieGO.isActive && !LR_FryGO.isActive)
//print("Congratulations");

}

}
