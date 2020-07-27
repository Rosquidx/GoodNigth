using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int Socoret = 0;
    public string ScoreString = "Score";
    // Start is called before the first frame update


    public Text TextScore;

    public static Score ScoreGame;

    void Awake()
    {
        ScoreGame = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = ScoreString+": "+ Socoret.ToString();
        }
    }
}
