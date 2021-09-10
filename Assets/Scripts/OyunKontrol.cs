using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour {

	public Text kazananText;
	public Text[] butonText;

	public GameObject[] butonlar;

	public static bool bitti = false;

	void Update () 
	{
		if (bitti)
		{
			//kaybeden oyuncunun seçtiği butonlar kırmızı olur
			for (int i = 0; i < butonlar.Length; i++)
			{
				if (butonlar[i].GetComponent<Button>().image.color != Color.green && butonText[i].text != "")
				{
					butonlar[i].GetComponent<Button>().image.color = Color.red;
				}
			}
		}
		else
		{
			for (int i = 0; i < butonlar.Length; i++)
			{
					butonlar[i].GetComponent<Button>().image.color = Color.white;
			}
		}

		for (int i = 0; i < 3; i++)
		{
			//satırdan kazanan belli olur
			if(butonText[0 + (3 * i)].text != "" && butonText[0 + (3 * i)].text == butonText[1 + (3 * i)].text && butonText[1 + (3 * i)].text == butonText[2 + (3 * i)].text)
			{
				if(butonText[0 + (3 * i)].text == "X")
				{
					kazananText.text = "Kazanan: X";

					for (int j = 0; j < 3; j++)
						butonlar[j + (3 * i)].GetComponent<Button>().image.color = Color.green;

					bitti = true;
				}
				else
				{
					kazananText.text = "Kazanan: O";

					for (int j = 0; j < 3; j++)
						butonlar[j + (3 * i)].GetComponent<Button>().image.color = Color.green;

					bitti = true;
				}
			}

			//sütundan kazanan belli olur
			if (butonText[i].text != "" && butonText[i].text == butonText[3 + i].text && butonText[3 + i].text == butonText[6 + i].text)
			{
				if (butonText[i].text == "X")
				{
					kazananText.text = "Kazanan: X";

					butonlar[i].GetComponent<Button>().image.color = Color.green;
					butonlar[3 + i].GetComponent<Button>().image.color = Color.green;
					butonlar[6 + i].GetComponent<Button>().image.color = Color.green;

					bitti = true;
				}
				else
				{
					kazananText.text = "Kazanan: O";

					butonlar[i].GetComponent<Button>().image.color = Color.green;
					butonlar[3 + i].GetComponent<Button>().image.color = Color.green;
					butonlar[6 + i].GetComponent<Button>().image.color = Color.green;

					bitti = true;
				}
			}
		}

		//sol çaprazdan kazanan belli olur
		if (butonText[0].text != "" && butonText[0].text == butonText[4].text && butonText[4].text == butonText[8].text)
		{
			if(butonText[0].text == "X")
			{
				kazananText.text = "Kazanan: X";

				for (int i = 0; i < 3; i++)
					butonlar[4 * i].GetComponent<Button>().image.color = Color.green;

				bitti = true;
			}
			else
			{
				kazananText.text = "Kazanan: O";

				for (int i = 0; i < 3; i++)
					butonlar[4 * i].GetComponent<Button>().image.color = Color.green;

				bitti = true;
			}
		}

		//sağ çaprazdan kazanan belli olur
		if (butonText[2].text != "" && butonText[2].text == butonText[4].text && butonText[4].text == butonText[6].text)
		{
			if (butonText[2].text == "X")
			{
				kazananText.text = "Kazanan: X";

				for (int i = 2; i < 7; i += 2)
					butonlar[i].GetComponent<Button>().image.color = Color.green;

				bitti = true;
			}
			else
			{
				kazananText.text = "Kazanan: O";

				for (int i = 2; i < 7; i += 2)
					butonlar[i].GetComponent<Button>().image.color = Color.green;

				bitti = true;
			}
		}

		//reset
		if (Input.GetKey(KeyCode.R))
		{
			EditorSceneManager.LoadScene(0);
			bitti = false;
		}
	}
}
