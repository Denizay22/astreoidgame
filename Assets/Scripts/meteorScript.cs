using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorScript : MonoBehaviour
{
    public GameObject miniMeteor1;
    public GameObject miniMeteor2;
    public GameObject miniMeteor3;
    private ManageGame gm;
    private healthScript healthScript;
    private score scoreScript;
    private float meteorSpeed;
    private float meteorLifespan;
    private void Awake() {
        gm = FindObjectOfType<ManageGame>();
        healthScript = FindObjectOfType<healthScript>();
        scoreScript = FindObjectOfType<score>();
        meteorSpeed = gm.meteorSpeed;
        meteorLifespan = gm.meteorLifespan;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            healthScript.decreaseHealth();
            GameObject.Destroy(gameObject, 0f);
            gm.ShakeCamera(1f);
        }
        if(other.tag == "ammo"){
            scoreScript.addScore(gm.meteorPoint);
            //Spawn mini meteor 1
            if(Random.Range(0f,1f) < gm.miniMeteor1Change){
                GameObject minimeteorr1 = (GameObject)Instantiate(miniMeteor1, gameObject.transform.position, Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));
                minimeteorr1.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-meteorSpeed,meteorSpeed),
                Random.Range(-meteorSpeed, meteorSpeed));

                Object.Destroy(minimeteorr1, meteorLifespan);
            }
            //Spawn mini meteor 2
            if(Random.Range(0f, 1f) < gm.miniMeteor2Change){
                GameObject minimeteorr2 = (GameObject)Instantiate(miniMeteor2, gameObject.transform.position, Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));
                minimeteorr2.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-meteorSpeed,meteorSpeed),
                Random.Range(-meteorSpeed, meteorSpeed));

                Object.Destroy(minimeteorr2, meteorLifespan);
            }
            //Spawn mini meteor 3
            if(Random.Range(0f, 1f) < gm.miniMeteor3Change){
                GameObject minimeteorr3 = (GameObject)Instantiate(miniMeteor3, gameObject.transform.position, Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteorr3.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-meteorSpeed,meteorSpeed),
                Random.Range(-meteorSpeed, meteorSpeed));

                Object.Destroy(minimeteorr3, meteorLifespan);
            }
            //destroy big meteor and ammo
            Object.Destroy(other, 0f);
            Object.Destroy(gameObject, 0f);
        }
    }
}

                