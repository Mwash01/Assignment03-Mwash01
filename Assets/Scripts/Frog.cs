using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject frog;
    public Text livesText;
    public AudioSource Audio;
    private bool hit = false;

    private void Start() {
        livesText.text = "Lives: " + Data.playerLives;
        if(Data.music) {
            Audio.enabled = true;
        }
        else {
            Audio.enabled = false;
        }
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            if (rb.transform.position.x != 5) {
                rb.MovePosition(rb.position + Vector2.right);   //prevents from moving off screen
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (rb.transform.position.x != -5) {
                rb.MovePosition(rb.position + Vector2.left);
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow)) {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            if (rb.transform.position.y != -4) {
                rb.MovePosition(rb.position + Vector2.down);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Car" && !hit) {
            hit = true;
            Data.playerLives -= 1;
            //Data.scoreNum = 0;
            if (Data.playerLives == 0) {
                SceneManager.LoadScene("Credits");
            }
            else {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
