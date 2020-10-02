using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ManageGame gm;
    public GameObject meteor;
    public GameObject miniMeteor1;
    public GameObject miniMeteor2;
    public GameObject miniMeteor3;
    public Transform leftBorder;
    public Transform rightBorder;
    public Transform upBorder;
    public Transform downBorder;
    private void Start(){
        StartCoroutine(SpawnMeteor());
    }
    public IEnumerator SpawnMeteor(){
        while(!gm.isDead){
            //downBorder
            if(Random.Range(0f,1f) < gm.miniMeteorsSpawnChange){
                //spawn meteor1
                GameObject minimeteor1 = (GameObject)Instantiate(miniMeteor1, downBorder.position + new Vector3(Random.Range(-downBorder.lossyScale.x/2f,
                downBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor1.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed));

                Object.Destroy(minimeteor1, gm.meteorLifespan);
                //spawn meteor2
                GameObject minimeteor2 = (GameObject)Instantiate(miniMeteor2, downBorder.position + new Vector3(Random.Range(-downBorder.lossyScale.x/2f,
                downBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor2.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed));

                Object.Destroy(minimeteor2, gm.meteorLifespan);
                //spawn meteor3
                GameObject minimeteor3 = (GameObject)Instantiate(miniMeteor3, downBorder.position + new Vector3(Random.Range(-downBorder.lossyScale.x/2f,
                downBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor3.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed));

                Object.Destroy(minimeteor3, gm.meteorLifespan);
            }
            else{
                GameObject meteorr = (GameObject)Instantiate(meteor, downBorder.position + new Vector3(Random.Range(-downBorder.lossyScale.x/2f,
                downBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                meteorr.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed));
                Object.Destroy(meteorr, gm.meteorLifespan);
            }

            //upBorder
            if(Random.Range(0f,1f) < gm.miniMeteorsSpawnChange){
                //spawn meteor1
                GameObject minimeteor1 = (GameObject)Instantiate(miniMeteor1, upBorder.position + new Vector3(Random.Range(-upBorder.lossyScale.x/2f,
                upBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor1.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed * 0.1f, -gm.meteorSpeed));

                Object.Destroy(minimeteor1, gm.meteorLifespan);
                //spawn meteor2
                GameObject minimeteor2 = (GameObject)Instantiate(miniMeteor2, upBorder.position + new Vector3(Random.Range(-upBorder.lossyScale.x/2f,
                upBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor2.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed * 0.1f, -gm.meteorSpeed));

                Object.Destroy(minimeteor2, gm.meteorLifespan);
                //spawn meteor3
                GameObject minimeteor3 = (GameObject)Instantiate(miniMeteor3, upBorder.position + new Vector3(Random.Range(-upBorder.lossyScale.x/2f,
                upBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor3.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed * 0.1f, -gm.meteorSpeed));

                Object.Destroy(minimeteor3, gm.meteorLifespan);
            }
            else{
                GameObject meteorr = (GameObject)Instantiate(meteor, upBorder.position + new Vector3(Random.Range(-upBorder.lossyScale.x/2f,
                upBorder.lossyScale.x/2f), 0f, 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                meteorr.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed,gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed * 0.1f, -gm.meteorSpeed));

                Object.Destroy(meteorr, gm.meteorLifespan);
            }
            //leftBorder
            if(Random.Range(0f,1f) < gm.miniMeteorsSpawnChange){
                //spawn meteor1
                GameObject minimeteor1 = (GameObject)Instantiate(miniMeteor1, leftBorder.position + new Vector3(0f, Random.Range(-leftBorder.lossyScale.y/2f,
                leftBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor1.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));

                Object.Destroy(minimeteor1, gm.meteorLifespan);
                //spawn meteor2
                GameObject minimeteor2 = (GameObject)Instantiate(miniMeteor2, leftBorder.position + new Vector3(0f, Random.Range(-leftBorder.lossyScale.y/2f,
                leftBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor2.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));

                Object.Destroy(minimeteor2, gm.meteorLifespan);
                //spawn meteor3
                GameObject minimeteor3 = (GameObject)Instantiate(miniMeteor3, leftBorder.position + new Vector3(0f, Random.Range(-leftBorder.lossyScale.y/2f,
                leftBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor3.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));

                Object.Destroy(minimeteor3, gm.meteorLifespan);
            }
            else{
                GameObject meteorr = (GameObject)Instantiate(meteor, leftBorder.position + new Vector3(0f, Random.Range(-leftBorder.lossyScale.y/2f,
                leftBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                meteorr.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(gm.meteorSpeed * 0.1f, gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));
                Object.Destroy(meteorr, gm.meteorLifespan);
            }
            //rightBorder
            if(Random.Range(0f,1f) < gm.miniMeteorsSpawnChange){
                //spawn meteor1
                GameObject minimeteor1 = (GameObject)Instantiate(miniMeteor1, rightBorder.position + new Vector3(0f, Random.Range(-rightBorder.lossyScale.y/2f,
                rightBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor1.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed * 0.1f,-gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));

                Object.Destroy(minimeteor1, gm.meteorLifespan);
                //spawn meteor2
                GameObject minimeteor2 = (GameObject)Instantiate(miniMeteor2, rightBorder.position + new Vector3(0f, Random.Range(-rightBorder.lossyScale.y/2f,
                rightBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor2.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed * 0.1f,-gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));

                Object.Destroy(minimeteor2, gm.meteorLifespan);
                //spawn meteor3
                GameObject minimeteor3 = (GameObject)Instantiate(miniMeteor3, rightBorder.position + new Vector3(0f, Random.Range(-rightBorder.lossyScale.y/2f,
                rightBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                minimeteor3.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed * 0.1f,-gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));

                Object.Destroy(minimeteor3, gm.meteorLifespan);
            }
            else{
                GameObject meteorr = (GameObject)Instantiate(meteor, rightBorder.position + new Vector3(0f, Random.Range(-rightBorder.lossyScale.y/2f,
                rightBorder.lossyScale.y/2f), 0f), Quaternion.Euler(0f, 0f, Random.Range(-180, 180)));

                meteorr.GetComponent<Rigidbody2D>().velocity = new Vector3(Random.Range(-gm.meteorSpeed * 0.1f,-gm.meteorSpeed),
                Random.Range(-gm.meteorSpeed, gm.meteorSpeed));
                Object.Destroy(meteorr, gm.meteorLifespan);
            }
            yield return new WaitForSeconds(Random.Range(gm.minTime,gm.maxTime));
        }
    }
}