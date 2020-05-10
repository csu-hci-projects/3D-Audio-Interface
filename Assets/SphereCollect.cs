using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

public class SphereCollect : MonoBehaviour
{
    public GameObject[] allSpheres;
    public int currSphere;

    void Start()
    {
        allSpheres = new GameObject[11];
        currSphere = 0;

        GameObject[] sphere1 = GameObject.FindGameObjectsWithTag("Sphere1");
        GameObject[] sphere2 = GameObject.FindGameObjectsWithTag("Sphere2");
        GameObject[] sphere3 = GameObject.FindGameObjectsWithTag("Sphere3");
        GameObject[] sphere4 = GameObject.FindGameObjectsWithTag("Sphere4");
        GameObject[] sphere5 = GameObject.FindGameObjectsWithTag("Sphere5");
        GameObject[] sphere6 = GameObject.FindGameObjectsWithTag("Sphere6");
        GameObject[] sphere7 = GameObject.FindGameObjectsWithTag("Sphere7");
        GameObject[] sphere8 = GameObject.FindGameObjectsWithTag("Sphere8");
        GameObject[] sphere9 = GameObject.FindGameObjectsWithTag("Sphere9");
        GameObject[] sphere10 = GameObject.FindGameObjectsWithTag("Sphere10");
        GameObject[] sphere11 = GameObject.FindGameObjectsWithTag("Sphere11");
        
        allSpheres[0] = sphere1[0];
        allSpheres[1] = sphere2[0];
        allSpheres[2] = sphere3[0];
        allSpheres[3] = sphere4[0];
        allSpheres[4] = sphere5[0];
        allSpheres[5] = sphere6[0];
        allSpheres[6] = sphere7[0];
        allSpheres[7] = sphere8[0];
        allSpheres[8] = sphere9[0];
        allSpheres[9] = sphere10[0];
        allSpheres[10] = sphere11[0];

        foreach(GameObject sphere in allSpheres)
        {
            sphere.SetActive(false);
        }
       
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Sphere" + currSphere.ToString()));
        {
            col.gameObject.SetActive(false);
            gameObject.GetComponent<Score>().increaseScore();
            
            if (currSphere < 11)
            {
                allSpheres[currSphere].SetActive(true);
            }

            currSphere++;
        }
    }
}
