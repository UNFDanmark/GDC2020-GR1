using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GroundPoint : MonoBehaviour
{

    
    public float points = 0;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Point" )
         {

            points++;
            score.text = "point: " + points.ToString();
            
        }

    }
        

}
