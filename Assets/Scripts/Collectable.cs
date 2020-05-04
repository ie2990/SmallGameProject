using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Collectable : MonoBehaviour
{
    public int coins = 0;
    public int winScore = 4;

    public Text countText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            Destroy(collision.gameObject);
            coins += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + coins.ToString();


        if (coins >= winScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
