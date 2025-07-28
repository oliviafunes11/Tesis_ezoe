using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string Comenzar)
    {
        SceneManager.LoadScene(Comenzar);
    }
    public void VolverAlMenu()
    {
    SceneManager.LoadScene("Mainmenu");
    }


}





