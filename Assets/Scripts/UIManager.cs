using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void nama()
    {
        print("Created by Heldi Arisandi - 149251970100-85");
    }

    public void Loads(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void exit()
    {
        Application.Quit();
    }



}
