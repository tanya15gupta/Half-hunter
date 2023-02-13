using UnityEngine;
namespace HalfHunter.Player
{
    public class PlayerModel
    {
        public float Speed;
        public float JumpHeight;
		public PlayerModel(PlayerDataSO _playerDataSO)
        {
            Speed = _playerDataSO.Speed;
            JumpHeight = _playerDataSO.JumpHeight;
        }
    }
}
