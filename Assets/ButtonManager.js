#pragma strict

public var PlayButton : UI.Button;
public var SButton : UI.Button;
public var TButton : UI.Button;
//public var ScoreWord : UI.Text;
public var ScoreText : UI.Text;
private var NumScore : int;

function Start () {
	
	NumScore = 0;
	//IncreaseScore ();

}

function Update () {

}

function Play () {
	
	print("F U");
}

function IncreaseScore () {

	NumScore = NumScore + 10;
	ScoreText.text = NumScore.ToString ();
 
 }

 function DecreaseScore () {
	//everytime TButton is clicked, score decreases.
 	
 	NumScore = NumScore - 10;
 	ScoreText.text = NumScore.ToString ();

 }

