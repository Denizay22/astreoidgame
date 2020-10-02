using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthScript : MonoBehaviour
{
    public GameObject hearth1;
    public GameObject hearth2;
    public GameObject hearth3;
    public GameObject player;
    private int health = 3;
    public void decreaseHealth(){
        switch (health)
        {
            case 1:
                GameObject.Destroy(hearth1, 0f);
                GameObject.Destroy(player, 0f);
                Invoke("LoadDeathScene", 1f);
                break;
            case 2:
                GameObject.Destroy(hearth2, 0f);
                break;
            case 3:
                GameObject.Destroy(hearth3, 0f);
                break;
        }
        health--;
    }
    private void LoadDeathScene(){
        SceneManager.LoadScene("DeathScene");
    }
}
