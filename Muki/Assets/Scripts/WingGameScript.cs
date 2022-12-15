using UnityEngine;
using UnityEngine.SceneManagement;

public class WingGameScript : MonoBehaviour
{
    public void Win()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);s
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
