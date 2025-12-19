using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int requiredScore = 3;
    public int currentScore = 0;
    public TextMeshProUGUI currentRoundText;
    public GameObject levelCompleteUI;

    // Update is called once per frame
    void Update()
    {
        currentRoundText.text = "Score: " + currentScore + "/" + requiredScore;
        if (currentScore == requiredScore)
        {
            levelCompleteUI.SetActive(true);
            Time.timeScale = 0;
            currentScore = 0;

        }
    }
}
