using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtonManagerCs : MonoBehaviour {

public Button FryButton;
public Button KylieButton; 
public Button KimButton; 
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
	//Everytime Kylie's doublechin is pressed, score increases.
	print("FU");
	
	NumScore = NumScore + 10;
	ScoreText.text = NumScore.ToString ();
 
 }

 public void DecreaseScore () {
	//everytime KimButton is clicked, score decreases.
 	
 	NumScore = NumScore - 10;
 	ScoreText.text = NumScore.ToString ();

 }

}