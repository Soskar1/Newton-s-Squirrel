using UnityEngine;

public class PlayerDeath : MonoBehaviour, IDying
{
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private AudioSource _source;

    public void Die()
    {
        _gameOver.SetActive(true);
        Time.timeScale = 0;
        _source.Play();
    }
}
