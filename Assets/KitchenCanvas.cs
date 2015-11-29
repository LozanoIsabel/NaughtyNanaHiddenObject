using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KitchenCanvas : MonoBehaviour {

public Button Kitchen_FryButton;
public Button Kitchen_KylieButton;
public Button Kitchen_PterodactylKim;
public Button Kitchen_Kim2Krying;
public Button Kitchen_Kanye;
public GameObject Kitchen_Kim2KryingGO;
public GameObject Kitchen_PterodactylKimGO;
public GameObject Kitchen_KanyeGO;
public GameObject Kitchen_KylieGO;
public GameObject Kitchen_FryGO;

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