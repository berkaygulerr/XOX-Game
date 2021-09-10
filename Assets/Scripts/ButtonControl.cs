using UnityEngine.UI;
using UnityEngine;
public class ButtonControl : MonoBehaviour {

	public Text siradakiText;
	public string sira = "x";
	void Update () 
	{
		if(sira == "x")
		{
			siradakiText.text = "Sıradaki: X";
		}
		else
		{
			siradakiText.text = "Sıradaki: O";
		}

		if(OyunKontrol.bitti == true)
		{
			for (int i = 0; i < 9; i++)
			{
				transform.GetChild(i).GetComponent<Button>().interactable = false;
			}
		}
	}
	public void ButonDegis(int index)
	{
		Text buttonText = transform.GetChild(index).GetChild(0).GetComponent<Text>();

		if(sira == "x")
		{
			buttonText.text = "X";
		}
		else
		{
			buttonText.text = "O";
		}

		transform.GetChild(index).GetComponent<Button>().interactable = false;

		if(sira == "x")
		{
			sira = "o";
		}
		else
		{
			sira = "x";
		}
	}
}
