using System.Collection;
using System.Collection.Generic;
using UnityEngine;

public class DestroyByContact : Monobehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    public GUIText scoreText;
    private int score;
    private GameController gameController;

    void start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameController>();
        }
        if (gameController == null)
        {
            Debug.Log ("Cannot find 'GameController' scripts")
        }
        score = 0;
        UpdateScore();
    }

public void AddScore (int newScoreValue)
{
    score += newScoreValue;
    UpdateScore();
}

void UpdateScore()
{
    scoreText.text = "Score: " + score;
}

void OnTriggerEnter(Collider other)
{
    if(other.tag == "Boundary")
    {
        return;
    }
    gameController.AddScore (scoreValue);
    Destroy(other.GameObject);
    Destroy(GameObject);
}
}