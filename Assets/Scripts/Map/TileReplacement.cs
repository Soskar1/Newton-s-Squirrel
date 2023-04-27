using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TileReplacement : MonoBehaviour
{
    [SerializeField] private List<Ground> _tiles;
    [SerializeField] private Transform _player;
    [SerializeField] private float _distance;

    private Ground _firstTile;
    private Ground _endTile;

    private int index = 0;

    private void Awake()
    {
        LookForTheNewFirstTile();
        _endTile = _tiles.Last();
    }

    private void Update()
    {
        if (Vector2.Distance(_player.position, _endTile.endPosition.position) < _distance)
        {
            _firstTile.Replace(_endTile.endPosition);

            _endTile.endPosition.gameObject.SetActive(false);
            _endTile = _firstTile;
            LookForTheNewFirstTile();
        }
    }

    private void LookForTheNewFirstTile()
    {
        _firstTile = _tiles[index % _tiles.Count];
        index++;
    }
}
