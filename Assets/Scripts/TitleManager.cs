using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleManager : MonoBehaviour {

    public GameObject PlayInvaderText;

	public void PlayButton (string sceneName)
	{
        SceneManager.LoadScene(sceneName);
	}
    
    public void GreenColorChangue(bool estate)  //estate: si es true, pondrá el objeto en verde; Si es false, en blanco;
    {
        if(estate == true)
        {
            PlayInvaderText.GetComponent<Text>().color = Color.green;
        }else
        {
            PlayInvaderText.GetComponent<Text>().color = Color.white;
        }
    }
}
