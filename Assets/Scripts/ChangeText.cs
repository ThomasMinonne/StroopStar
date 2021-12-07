using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    private TextMeshProUGUI tmp;
	private string[] testo = new string[]{"Rosso", "Giallo", "Ciano", "Fucsia", "Verde"};
    private int i;
	// Update is called once per frame
    void Update()
    {
        
    }
	
	public void changeColorText(string color){
		i = Random.Range(0, 5);
		if(color == "GreenStar"){
			tmp = gameObject.GetComponent<TextMeshProUGUI>();
			tmp.text = testo[i];
			tmp.color = new Color32(0, 144, 0, 255);
		}
		if(color == "YellowStar"){
			tmp = gameObject.GetComponent<TextMeshProUGUI>();
			tmp.text = testo[i];
			tmp.color = new Color32(144, 144, 0, 255);
		}
		if(color == "RedStar"){
			tmp = gameObject.GetComponent<TextMeshProUGUI>();
			tmp.text = testo[i];
			tmp.color = new Color32(144, 0, 0, 255);
		}
		if(color == "BlueStar"){
			tmp = gameObject.GetComponent<TextMeshProUGUI>();
			tmp.text = testo[i];
			tmp.color = new Color32(0, 144, 144, 255);
		}
		if(color == "PinkStar"){
			tmp = gameObject.GetComponent<TextMeshProUGUI>();
			tmp.text = testo[i];
			tmp.color = new Color32(144, 0, 144, 255);
		}
	}
}
