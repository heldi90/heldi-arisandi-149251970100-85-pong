using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 speed;
    Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
