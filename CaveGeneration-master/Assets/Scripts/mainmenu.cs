using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {
public AudioSource audio ;
	public void PlayGame(){
		audio.Play();
		SceneManager.LoadScene("new scene");
		

	}
	public void Options(){
		audio.Play(44100);
	}
	public void QuitGame(){
		audio.Play();
		Application.Quit();
		
	}
}
