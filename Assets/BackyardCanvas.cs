using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Backyard : MonoBehaviour {

public Button Backyard_FryButton;
public Button Backyard_KylieButton;
public Button Backyard_PterodactylKim;
public Button Backyard_Kim2Krying;
public Button Backyard_Kanye;
public GameObject Backyard_Kim2KryingGO;
public GameObject Backyard_PterodactylKimGO;
public GameObject Backyard_KanyeGO;
public GameObject Backyard_KylieGO;
public GameObject Backyard_FryGO;

//public var ScoreWord : UI.Text;
public Text ScoreText;
private int NumScore;
private AudioSource HotlineBling;


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
}