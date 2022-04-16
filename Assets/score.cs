using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    void Update()
    {
        if (player != null)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
