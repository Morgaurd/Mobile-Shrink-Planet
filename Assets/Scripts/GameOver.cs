using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{

		}

		GetComponent<RectTransform>().localScale = Vector3.one * Planet.Size;
	}

	public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

	public void Screen()
    {
		GameManager.instance.Restart();
	}

}
