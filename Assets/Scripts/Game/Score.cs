using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance = null;

    [SerializeField] private TextMeshProUGUI _scoreText;

    private int _points;
    public int Points { get { return _points; } }

    [SerializeField] private float _gameDifficulty;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void GainPoints(int quantity)
    {
        _points += quantity;
        Time.timeScale += (float)quantity / _gameDifficulty;
        _scoreText.SetText("Score: " + _points.ToString());
    }
}
