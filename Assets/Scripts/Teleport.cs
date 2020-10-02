using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float offset = 1.5f;
    private float verticalBorderPos;
    private float horizontalBorderPos;
    private void Awake() {
        verticalBorderPos = GameObject.Find("Borders/UpBorder").gameObject.GetComponent<Transform>().position.y;
        horizontalBorderPos = GameObject.Find("Borders/RightBorder").gameObject.GetComponent<Transform>().position.x;
    }
    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.name == "LeftBorder"){
            transform.position = new Vector3(horizontalBorderPos - offset, transform.position.y, 0); 
        }
        if(collider.gameObject.name == "RightBorder"){
            transform.position = new Vector3(-horizontalBorderPos + offset, transform.position.y, 0); 
        }
        if(collider.gameObject.name == "UpBorder"){
            transform.position = new Vector3(transform.position.x, -verticalBorderPos + offset, 0);
        }
        if(collider.gameObject.name == "DownBorder"){
            transform.position = new Vector3(transform.position.x, verticalBorderPos - offset, 0);
        }
        
    }
}