using UnityEngine;
using TMPro;

[RequireComponent(typeof(Score))]
public class Highscore : MonoBehaviour
{
    [SerializeField] private Score _score;
    [SerializeField] private TextMeshProUGUI _highscoreText;

    private const string SAVE_KEY = "Highscore";

    private int _highscore;

    private void Awake()
    {
        _highscore = PlayerPrefs.GetInt(SAVE_KEY);
        _highscoreText.SetText("Highscore: " + _highscore.ToString());
    }

    public void TrySaveScore()
    {
        if (_score.Points > _highscore)
            PlayerPrefs.SetInt(SAVE_KEY, _score.Points);
    }
}
