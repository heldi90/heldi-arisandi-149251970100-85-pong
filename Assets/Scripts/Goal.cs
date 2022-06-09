using UnityEngine;

public class Goal : MonoBehaviour
{
    public static Goal Instance;
    public Transform resetBall;
    public int GoalMaksimal;
    public int ScorePlayer1;
    public int ScorePlayer2;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GoalsPlayer1(int score)
    {
        ScorePlayer1 = ScorePlayer1 + score;
    }

    public void GoalsPlayer2(int score)
    {
        ScorePlayer2 = ScorePlayer2 + score;
    }


    public void ResetBall()
    {
        resetBall.transform.position = new Vector2(0f, 0f);
    }
}
