using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaIzvade : MonoBehaviour {
	//Uzglabās tekstu, kurš paņemts no input laika
	public string teksts;
	//Lauks no, kura es tekstu paņemšu
	public GameObject ievadesLauks;
	//Teksta objekts, kur attēlot mainīgo teksta saturu
	public GameObject TekstaAttelosanasLauks;

	public void darbibasArTekstu(){
		teksts = ievadesLauks.GetComponent<Text> ().text;
		TekstaAttelosanasLauks.GetComponent<Text> ().text = "Sveiks " + teksts.ToUpper()+"!";
	}
}
