using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rig;
    public float speedVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = new Vector2(speed, rig.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gerakAwalPlayer2Lose()
    {

        rig = GetComponent<Rigidbody2D>();

        rig.velocity = new Vector2(speed, Random.Range(-7, 7));
    }


    public void gerakAwalPlayer1Lose()
    {
        rig = GetComponent<Rigidbody2D>();

        rig.velocity = new Vector2(-speed, Random.Range(-7, 7));
    }


    public void outs()
    {
        rig = GetComponent<Rigidbody2D>();

        rig.velocity = new Vector2(-speed, Random.Range(-7, 7));
    }


}
