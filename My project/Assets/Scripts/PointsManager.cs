using UnityEngine;
using UnityEngine.UI;   // For legacy text
using TMPro;            // The TextMeshPro 


public class PointsManager : MonoBehaviour
{
    // Public variables connected to the text boxes
    public Text LegacyPointText;
    public TextMeshProUGUI TMProPointsText;

    private int playerScore = 0;
    void UpdateScorePoints()
    {
        LegacyPointText.text = "Points: " + playerScore;
        TMProPointsText.text = "Avast! " + playerScore;
    }

    public void ScorePoints(int numberOfPoints)
    {
        playerScore += numberOfPoints;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScorePoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
