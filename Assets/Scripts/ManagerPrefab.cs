using UnityEngine;

public class ManagerPrefab : MonoBehaviour
{

    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;

    public GameObject[] clone;



    int cocok;


    public int randomMuncul;

    public float muncul;
    // Start is called before the first frame update
    void Start()
    {
        cocok = 0;

    }

    // Update is called once per frame
    void Update()
    {
        muncul -= Time.deltaTime;
        if (muncul <= 0)
        {
            if (Random.Range(1, 6) == 1 || Random.Range(1, 6) == 4 || Random.Range(1, 6) == 5)
            {
                munculPrefab(Random.Range(1, 4));


            }
            else
            {
                munculPrefab(Random.Range(1, 2));
                munculPrefab(Random.Range(3, 4));
            }


            clone = GameObject.FindGameObjectsWithTag("skill");

            if (clone[0] && clone[1] != null)
            {
                muncul = 20;
            }
            else
            {
                muncul = 5;
            }


        }


    }

    public void munculPrefab(int index)
    {
        if (index != cocok)
        {
            if (index == 1)
            {
                int rar = Random.Range(1, 8);
                if (rar > 4)
                {
                    Instantiate(prefab1, new Vector2(Random.Range(1f, 6f), Random.Range(-3f, 3f)), Quaternion.identity);
                }
                else
                {
                    Instantiate(prefab3, new Vector2(Random.Range(1f, 6f), Random.Range(-3f, 3f)), Quaternion.identity);

                }


                cocok = index;
                muncul = 5;
            }

            if (index == 2)
            {

                int rar = Random.Range(1, 8);
                if (rar > 4)
                {
                    Instantiate(prefab2, new Vector2(Random.Range(2f, 8f), Random.Range(-3f, 3f)), Quaternion.identity);
                }
                else
                {
                    Instantiate(prefab3, new Vector2(Random.Range(2f, 8f), Random.Range(-3f, 3f)), Quaternion.identity);

                }
                cocok = index;
                muncul = 5;
            }

            if (index == 3)
            {

                int rar = Random.Range(1, 8);
                if (rar > 4)
                {
                    Instantiate(prefab1, new Vector2(Random.Range(-1f, -6f), Random.Range(-3f, 3f)), Quaternion.identity);
                }
                else
                {
                    Instantiate(prefab3, new Vector2(Random.Range(-1f, -6f), Random.Range(-3f, 3f)), Quaternion.identity);

                }


                cocok = index;
                muncul = 5;
            }

            if (index == 4)
            {
                int rar = Random.Range(1, 8);
                if (rar > 4)
                {
                    Instantiate(prefab2, new Vector2(Random.Range(-2f, -8f), Random.Range(-3f, 3f)), Quaternion.identity);
                }
                else
                {

                    Instantiate(prefab3, new Vector2(Random.Range(-2f, -8f), Random.Range(-3f, 3f)), Quaternion.identity);
                }




                cocok = index;
                muncul = 5;

            }
        }
        else
        {
            index = Random.Range(1, 4);
            munculPrefab(index);
        }

        // // Instantiate(prefab1, new Vector2(Random.Range(1f, 6f), Random.Range(-3f, 3f)), Quaternion.identity);
        // // Instantiate(prefab2, new Vector2(Random.Range(2f, 8f), Random.Range(-3f, 3f)), Quaternion.identity);


        // Instantiate(prefab1, new Vector2(Random.Range(-1f, -6f), Random.Range(-3f, 3f)), Quaternion.identity);
        // Instantiate(prefab2, new Vector2(Random.Range(-2f, -8f), Random.Range(-3f, 3f)), Quaternion.identity);
        // muncul = 10;

    }
}
