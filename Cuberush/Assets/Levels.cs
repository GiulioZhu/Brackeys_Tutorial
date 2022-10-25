using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    int base_level = 2;
    public void LoadLevel1()
    {
        SceneManager.LoadScene(base_level);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene(base_level + 1);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene(base_level + 2);
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene(base_level + 3);
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene(base_level + 4);
    }

}
