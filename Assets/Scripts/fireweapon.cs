using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Mathematics.math;
public class fireweapon : MonoBehaviour
{

    public GameObject ammo;
    public GameObject backWeapons;
    public GameObject leftWeapon;
    public GameObject rightWeapon;
    public GameObject frontWeapons;
    public GameObject frontWeapon1;
    public GameObject frontWeapon2;
    public Rigidbody2D playerrigid;
    public ManageGame gm;
    private float timetospawn = 0f;
    private bool fire_front = false;

    void FixedUpdate(){
        if(Input.GetMouseButton(0)){
            if(timetospawn < Time.time && fire_front == true){
                fireFrontWeapons();
                fire_front = false;
            }
            else if(timetospawn < Time.time && fire_front == false){
                fireBackWeapons();
                fire_front = true;
            }
        }
    }

    void fireFrontWeapons(){
        GameObject laser1 = (GameObject)Instantiate(ammo, frontWeapon1.transform.position, gameObject.transform.rotation);
        
        laser1.GetComponent<Rigidbody2D>().velocity = new Vector2(-sin(laser1.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) *
        gm.speed, cos(laser1.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * gm.speed);
        
        laser1.GetComponent<Rigidbody2D>().AddForce(transform.up * Time.deltaTime * gm.forwardForce * playerrigid.velocity.magnitude * gm.playerSpeedModifier);

        Object.Destroy(laser1, gm.lifespan);

        GameObject laser2 = (GameObject)Instantiate(ammo, frontWeapon2.transform.position, gameObject.transform.rotation);
        laser2.GetComponent<Rigidbody2D>().velocity = new Vector2(-sin(laser2.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) *
        gm.speed, cos(laser2.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * gm.speed);
        
        laser2.GetComponent<Rigidbody2D>().AddForce(transform.up * Time.deltaTime * gm.forwardForce * playerrigid.velocity.magnitude * gm.playerSpeedModifier);

        frontWeapons.GetComponent<Animator>().Play("weapons_front_anim");
        Object.Destroy(laser2, gm.lifespan);
        timetospawn = Time.time + (1/gm.rateOfFire);
    }
    void fireBackWeapons(){
        GameObject laser1 = (GameObject)Instantiate(ammo, leftWeapon.transform.position, gameObject.transform.rotation);
        
        laser1.GetComponent<Rigidbody2D>().velocity = new Vector2(-sin(laser1.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) *
        gm.speed, cos(laser1.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * gm.speed);
        
        laser1.GetComponent<Rigidbody2D>().AddForce(transform.up * Time.deltaTime * gm.forwardForce * playerrigid.velocity.magnitude * gm.playerSpeedModifier);

        Object.Destroy(laser1, gm.lifespan);

        GameObject laser2 = (GameObject)Instantiate(ammo, rightWeapon.transform.position, gameObject.transform.rotation);
        laser2.GetComponent<Rigidbody2D>().velocity = new Vector2(-sin(laser2.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) *
        gm.speed, cos(laser2.transform.rotation.eulerAngles.z * Mathf.Deg2Rad) * gm.speed);
        
        laser2.GetComponent<Rigidbody2D>().AddForce(transform.up * Time.deltaTime * gm.forwardForce * playerrigid.velocity.magnitude * gm.playerSpeedModifier);

        backWeapons.GetComponent<Animator>().Play("weapons_back_anim");
        Object.Destroy(laser2, gm.lifespan);
        timetospawn = Time.time + (1/gm.rateOfFire);
    }
}
