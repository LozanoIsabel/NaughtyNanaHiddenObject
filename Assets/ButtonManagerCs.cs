using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtonManagerCs : MonoBehaviour {

public Button FryButton;
public Button KylieButton;
public Button KimButton;
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


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	if (!FryButton.isActiveAndEnabled && !KimButton.isActiveAndEnabled && !KylieButton.isActiveAndEnabled)
		print("Congratulations!");
		

	}

public void IncreaseScore () {
	NumScore = NumScore + 10;
	ScoreText.text = NumScore.ToString ();
 
 }

 public void SpecialPointScore () {
 	NumScore = NumScore + 1688;
 	ScoreText.text = NumScore.ToString ();

 }

}
