using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class deathScreenScore : MonoBehaviour
{
    public Text currentScore;
    public void Start(){
        currentScore.text = PlayerPrefs.GetInt("CurrentScore", 0).ToString();
        PlayerPrefs.SetInt("CurrentScore", 0);
    }
}
