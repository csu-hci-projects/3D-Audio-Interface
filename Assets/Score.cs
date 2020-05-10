using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.IO;
using UnityStandardAssets.Characters.FirstPerson;

public class Score : MonoBehaviour
{
    public int score;
    public float timePassed;
    GameObject[] player; 

    void Start()
    {
        score = 0;
        timePassed = 0;
        player = GameObject.FindGameObjectsWithTag("MainCamera");
        player[0].GetComponent<Light>().enabled = false;
    }

    void Update()
    {
        timePassed += Time.deltaTime;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
    }

    public void increaseScore()
    {
        score++;
        StreamWriter writer = new StreamWriter("./times.txt", true);
        writer.WriteLine("Sphere" + (score-1).ToString() + ": " + (timePassed).ToString());
        writer.Close();
        timePassed = 0;

        if (score == 4)
        {
            wait();
            transform.position = new Vector3(705, 3, 1300);
            wait();
        }

        if (score == 8)
        {
            wait();
            transform.position = new Vector3(-527, 3, 477);
            wait();
            player[0].GetComponent<Light>().enabled = true;
        }

        if (score == 12)
        {
            wait();   
            wait();
            wait();
            wait();
            wait();
            Application.Quit();
        }

        

    }

}
