using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float speed;

    [Header("Input Settings")]
    public KeyCode UP;
    public KeyCode DOWN;

    Rigidbody2D rb;
    Transform pl;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pl = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ControllPaddle();
        batasMovePaddle();
    }


    void batasMovePaddle()
    {
        if (pl.transform.position.y <= -1.29f)
        {
            pl.transform.position = new Vector2(pl.transform.position.x, -1.29f);
        }

        if (pl.transform.position.y >= 1.29f)
        {
            pl.transform.position = new Vector2(pl.transform.position.x, 1.29f);
        }

    }

    void ControllPaddle()
    {
        if (Input.GetKey(UP))
        {
            rb.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(DOWN))
        {
            rb.velocity = Vector2.down * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }






}
