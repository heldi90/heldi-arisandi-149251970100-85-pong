using UnityEngine;

public class SkillManager : MonoBehaviour
{

    public GameObject skill2x;
    public float waktunya;

    private GameObject ball;
    Ball scriptball;
    // Start is called before the first frame update

    void Start()
    {
        ball = GameObject.FindWithTag("Ball");
        scriptball = ball.GetComponent<Ball>();

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
        scriptball.rig.velocity = scriptball.rig.velocity * scriptball.speedVelocity;
        Destroy(skill2x);

    }
}
