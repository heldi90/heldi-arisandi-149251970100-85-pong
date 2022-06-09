using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float speed;

    [Header("Input Settings Player 1")]
    public KeyCode UP_P1;
    public KeyCode DOWN_p1;

    [Header("Input Settings Player 2")]
    public KeyCode UP_p2;
    public KeyCode DOWN_p2;

    public Rigidbody2D[] rb;
    public Transform[] tr;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        ControllPaddle(0, "Player1", UP_P1, DOWN_p1);
        batasMovePaddle(0);

        ControllPaddle(1, "Player2", UP_p2, DOWN_p2);
        batasMovePaddle(1);
    }


    void batasMovePaddle(int index)
    {
        if (tr[index].transform.position.y <= -1.29f)
        {
            tr[index].transform.position = new Vector2(tr[index].transform.position.x, -1.29f);
        }

        if (tr[index].transform.position.y >= 1.29f)
        {
            tr[index].transform.position = new Vector2(tr[index].transform.position.x, 1.29f);
        }

    }

    void ControllPaddle(int index, string name, KeyCode UP, KeyCode DOWN)
    {
        if (Input.GetKey(UP))
        {
            rb[index].velocity = Vector2.up * speed;
            print($"tes debug Movement Paddle {name}  {rb[index].velocity}");
        }
        else if (Input.GetKey(DOWN))
        {
            rb[index].velocity = Vector2.down * speed;
            print($"tes debug Movement Paddle {name}  {rb[index].velocity}");
        }
        else
        {
            rb[index].velocity = Vector2.zero;
            print($"tes debug Movement Paddle {name} {rb[index].velocity}");
        }


    }






}
