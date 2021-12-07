using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    private TextMeshProUGUI tmp;
	private string[] testo = new string[]{"Rosso", "Giallo", "Ciano", "Fucsia", "Verde"};
	//Colori perché non si può né passare come parametro né si può fare un vettore in Color32
	private Color32 verde = new Color32(0,144,0,255);
	private Color32 giallo = new Color32(144,144,0,255);
	private Color32 rosso = new Color32(144,0,0,255);
	private Color32 ciano = new Color32(0,144,144,255);
	private Color32 fucsia = new Color32(144,0,144,255);
	//Store del colore casuale
	private Color32 color;
	//private Color32[] colori = new Color32[]{verde, giallo, rosso, ciano, fucsia};
    private int i;
	// Update is called once per frame
    void Update()
    {
        
    }
	
	public void changeColorText(string colorTxt, int mod){
		i = Random.Range(0, 5);
		tmp = gameObject.GetComponent<TextMeshProUGUI>();
		Debug.Log("Modalità:" + mod);
		if(mod != 0){
			int randomColor = Random.Range(0, 5);
			if(randomColor == 0){
				color = verde;
			}
			else if(randomColor == 1){
				color = giallo;
			}
			else if(randomColor == 2){
				color = rosso;
			}
			else if(randomColor == 3){
				color = ciano;
			}
			else if(randomColor == 4){
				color = fucsia;
			}
		}	
		if(colorTxt == "GreenStar"){
			if(mod == 0){
				tmp.text = testo[i];
				tmp.color = verde;
			}
			else{
				tmp.text = "Verde";
				Debug.Log(color);
				tmp.color = color;
			}
		}
		if(colorTxt == "YellowStar"){
			if(mod == 0){
				tmp.text = testo[i];
				Debug.Log(color);
				tmp.color = giallo;
			}
			else{
				tmp.text = "Giallo";
				Debug.Log(color);
				tmp.color = color;
			}
		}
		if(colorTxt == "RedStar"){
			if(mod == 0){
				tmp.text = testo[i];
				tmp.color = rosso;
			}
			else{
				tmp.text = "Rosso";
				Debug.Log(color);
				tmp.color = color;
			}
		}
		if(colorTxt == "BlueStar"){
			if(mod == 0){
				tmp.text = testo[i];
				tmp.color = ciano;
			}
			else{
				tmp.text = "Ciano";
				Debug.Log(color);
				tmp.color = color;
			}
		}
		if(colorTxt == "PinkStar"){
			if(mod == 0){
				tmp.text = testo[i];
				tmp.color = fucsia;
			}
			else{
				tmp.text = "Fucsia";
				Debug.Log(color);
				tmp.color = color;
			}
		}
	}
}
