using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public TMP_Text score;


    // Start is called before the first frame update
    void Start()
    {
        print(Goal.Instance.ScorePlayer1.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        score.text = $"{Goal.Instance.ScorePlayer1.ToString()}  :  {Goal.Instance.ScorePlayer2.ToString()}";

        if (Goal.Instance.ScorePlayer1.ToString() == Goal.Instance.GoalMaksimal.ToString() || Goal.Instance.ScorePlayer2.ToString() == Goal.Instance.GoalMaksimal.ToString())
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
