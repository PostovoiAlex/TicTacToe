using UnityEngine;

namespace TicTacToe
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Player[] players;
        Player _currentPlayer;
        [SerializeField] Field _field;
        [SerializeField] Turn _turn;

        void Awake()
        {
            _field.Init();
            _field.OnTileSelected += OnTileSelected;
            
            _turn.Init(_field);
            
            _turn.OnTurnStarted += OnTurnStarted;
            _turn.OnTurnEnded += OnTurnEnded;
        }

        void OnTileSelected()
        {
            _field.SetTileSprite(_field.LastSelectedTile, _currentPlayer.PlayerTileSprite);
        }

        public void Start()
        {
            StartTurn();
        }

        void OnTurnEnded()
        {
            //TODO: Check win condition

            if(_field.CheckTileWinCombination(_field.LastSelectedTile))
            {
                return;
            }

            StartTurn();
        }
        
        void OnTurnStarted()
        {
            //throw new System.NotImplementedException();
        }

        void StartTurn()
        {
            Player nextPlayer = GetNextPlayer();

            _currentPlayer = nextPlayer;
            
            _currentPlayer.StartTurn();
            _turn.StartTurn();
        }
        
        Player GetNextPlayer()
        {
            int nextPlayerIndex = 0;
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] == _currentPlayer)
                {
                    nextPlayerIndex = (++i) < players.Length ? i : 0;
                    break;
                }
            }

            return players[nextPlayerIndex];
        }
    }
}
