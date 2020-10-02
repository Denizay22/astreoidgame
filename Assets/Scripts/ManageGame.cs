using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ManageGame : MonoBehaviour
{
    private int milestoneCount = 1;
    public score scoreScript;
    public bool isDead = false;
    public float meteorSpeed = 3f;
    public float meteorLifespan = 15f;
    public int milestonePoint = 50;
    
    [Header("Camera Shake Values")]
    public float magnitude = 4f;
    public float roughness = 2f;
    public float fadeInTime = .1f;
    public float fadeOutTime = .8f;

    
    [Header("Meteor Spawn Times")]
    public float minTime = 2f;
    public float maxTime = 4f;


    [Header("Possibility of spawning 3 small meteors instead of a big one")]
    [Range(0f,1f)]
    public float miniMeteorsSpawnChange = 0.2f;
    [Header("Mini Meteor Spawn Changes When Big Meteor Dies")]
    [Range(0f,1f)]
    public float miniMeteor1Change = 0.2f;
    [Range(0f,1f)]
    public float miniMeteor2Change = 0.2f;
    [Range(0f,1f)]
    public float miniMeteor3Change = 0.2f;

    [Header("Ammo Properties")]
    public float speed = 10f;
    public float rateOfFire = 5f;
    public float lifespan = 5f;
    [Tooltip("How much player's speed affect ammo's forward speed")]
    [Range(0f,50f)]
    public float playerSpeedModifier = 15f;

    [Header("Player Properties")]
    public float rotateSpeed = 275f;
    public float forwardForce = 500f;
    public float maxSpeed = 5f;

    [Header("Point Settings")]
    public int meteorPoint = 5;
    public int miniMeteorPoint = 1;

    private void FixedUpdate() {
        if(scoreScript.point > milestoneCount * milestonePoint){
            miniMeteor1Change *=1.25f;
            miniMeteor2Change *=1.25f;
            miniMeteor3Change *=1.25f;
            minTime *= 0.9f;
            maxTime *= 0.9f;
            meteorSpeed *= 1.2f;
            milestoneCount++;
        }

    }

    public void ShakeCamera(float multiplier){
        CameraShaker.Instance.ShakeOnce(magnitude * multiplier,roughness * multiplier,fadeInTime,fadeOutTime);
    }

}
