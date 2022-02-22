using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParaditAttelu : MonoBehaviour {
	public GameObject bins;
	public GameObject lacis;
	public GameObject masina;
	public GameObject tante;
	public GameObject attelaTuretajs;
	public Sprite[] attelumasivs;
	public GameObject slaideris;

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
	public void binsPaKreisi(bool vetiba){
		bins.transform.localScale = new Vector2 (1 , 1);
	}
	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [0];
		else if (skaitlis == 1)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [1];
		else if (skaitlis == 2)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [2];	
	}
	public void mainitIzmeru(){
		float izmers = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1f*izmers, 1f*izmers);
	}
}
