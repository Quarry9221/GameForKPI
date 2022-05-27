using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    Text ScoreText;
    void Start()
    {
        ScoreText = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        ScoreText.text = "Score: " + score;
    }
}
