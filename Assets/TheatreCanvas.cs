using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Theatre : MonoBehaviour {

public Button Theatre_KylieButton;
public Button Theatre_PterodactylKim;
public Button Theatre_Kim2Krying;
public Button Theatre_Kanye;
public Button Theatre_Fry;
public GameObject Theatre_Kim2KryingGO;
public GameObject Theatre_PterodactylKimGO;
public GameObject Theatre_KanyeGO;
public GameObject Theatre_KylieGO;
public GameObject Theatre_FryGO;

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