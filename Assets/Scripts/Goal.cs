using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Frog") {
            Data.scoreNum += 100;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
