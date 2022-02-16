using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaditAttelu : MonoBehaviour {
	public GameObject bins;
	public GameObject lacis;
	public GameObject masina;
	public GameObject tante;

	public void binaAttelosana(bool vertiba){
		bins.SetActive (vertiba);
	}
	public void lacisAttelosana(bool vertiba){
		lacis.SetActive (vertiba);
	}
	public void masinaAttelosana(bool vertiba){
		masina.SetActive (vertiba);
	}
	public void tanteAttelosana(bool vertiba){
		tante.SetActive (vertiba);
	}
	public void binsPaLabi(bool vertiba){
		bins.transform.localScale = new Vector2 (-1, 1);
	}
	public void binsPaKreisi(bool vertiba){
		bins.transform.localScale = new Vector2 (1 , 1);
	}
}
