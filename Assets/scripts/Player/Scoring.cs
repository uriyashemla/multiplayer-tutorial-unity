using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class Scoring : MonoBehaviourPunCallbacks
{


    public Text score;
    public int ScoreForHit = 0;
    [SerializeField] string triggeringTag;

    void Start()
    {
        score = GameObject.Find("Canvas").GetComponent<Text>();
        score.text = "Score: " + ScoreForHit.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == triggeringTag )
        {
            ScoreForHit++;
            score.text = "Score: " + ScoreForHit.ToString();
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == triggeringTag )
        {
            ScoreForHit++;
            score.text = "Score: " + ScoreForHit.ToString();
        }
    }
}
