using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtonManagerCs : MonoBehaviour {

public Button FryButton;
public Button KylieButton;
public Button KimButton; 
public GameObject KylieGameObject;
public GameObject KryingKim;
public GameObject FryFryFry; 
//public var ScoreWord : UI.Text;
public Text ScoreText;
private int NumScore; 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public void IncreaseScore () {
	NumScore = NumScore + 18;
	ScoreText.text = NumScore.ToString ();
 
 }

 public void DecreaseScore () {
 	NumScore = NumScore - 10;
 	ScoreText.text = NumScore.ToString ();

 }

}
