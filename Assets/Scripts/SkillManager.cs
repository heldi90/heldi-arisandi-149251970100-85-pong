using UnityEngine;

public class SkillManager : MonoBehaviour
{

    public GameObject skill2x;
    public float waktunya;

    private GameObject ball;
    Ball scriptball;

    private GameObject paddle;

    PlayerManager player;


    // Start is called before the first frame update

    void Start()
    {
        ball = GameObject.FindWithTag("Ball");
        scriptball = ball.GetComponent<Ball>();

        paddle = GameObject.FindWithTag("manager");
        player = paddle.GetComponent<PlayerManager>();

    }

    // Update is called once per frame
    void Update()
    {
        waktu();
    }


    public void waktu()
    {
        waktunya -= Time.deltaTime;
        if (waktunya < 0)
        {
            Destroy(skill2x);
        }
    }

    public void speed2x()
    {
        scriptball.durasiSkill = 5;
        scriptball.rig.velocity = scriptball.rig.velocity * scriptball.speedVelocity;
        Destroy(skill2x);



    }

    public void SkillPaddle()
    {
        if (player.seranganPaddle1)
        {
            player.durasiSkillPaddle1 = 5;
        }

        if (player.seranganPaddle2)
        {
            player.durasiSkillPaddle2 = 5;
        }



        Destroy(skill2x);



    }
}
