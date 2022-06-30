using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rig;
    public float speedVelocity;
    public float durasiSkill;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = new Vector2(speed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (durasiSkill > 0)
        {

            durasiSkill -= Time.deltaTime;

            if (durasiSkill < 0)
            {
                rig.velocity = rig.velocity / speedVelocity;

            }
        }
    }

    public void gerakAwalPlayer2Lose()
    {

        rig = GetComponent<Rigidbody2D>();

        rig.velocity = new Vector2(speed, Random.Range(-7, 7));
        durasiSkill = 0;
    }


    public void gerakAwalPlayer1Lose()
    {
        rig = GetComponent<Rigidbody2D>();

        rig.velocity = new Vector2(-speed, Random.Range(-7, 7));
        durasiSkill = 0;
    }


    public void outs()
    {
        rig = GetComponent<Rigidbody2D>();

        rig.velocity = new Vector2(-speed, Random.Range(-7, 7));
        durasiSkill = 0;
    }


}
