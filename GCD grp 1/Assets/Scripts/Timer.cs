using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 5f;
    public Text timer;
    public float points;
    

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (GameObject.FindObjectsOfType<Timer>().Length > 1)
        {
            Destroy(gameObject);
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            time -= Time.deltaTime;
            timer.text = time.ToString("F2");

            if (time <= 0)
            {
                points = GameObject.FindGameObjectWithTag("PointsController").GetComponent<GroundPoint>().points;
                SceneManager.LoadScene(1);
            }
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            Destroy(gameObject);
        }

        else
        {
            GameObject.Find("Highscore").GetComponent<Text>().text = points.ToString();
        }


        

       
    }
}
