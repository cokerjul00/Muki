using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    public void Death()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }
}
