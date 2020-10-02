using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniMeteorScript : MonoBehaviour
{
    private healthScript healthScript;
    private score scoreScript;
    private ManageGame gm;
    private void Awake() {
        healthScript = FindObjectOfType<healthScript>();
        scoreScript = FindObjectOfType<score>();
        gm = FindObjectOfType<ManageGame>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            healthScript.decreaseHealth();
            GameObject.Destroy(gameObject, 0f);
            gm.ShakeCamera(.5f);
        }
        if(other.tag == "ammo"){
            Object.Destroy(other, 0f);
            scoreScript.addScore(gm.miniMeteorPoint);
            Object.Destroy(gameObject, 0f);
        }
    }
}
