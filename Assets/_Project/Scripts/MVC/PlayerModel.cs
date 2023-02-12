using UnityEngine;
namespace HalfHunter.Player
{
    public class PlayerModel
    {
        public float m_Speed;
        //public float m_RotationSensitivity;
       // public Vector2 m_MouseRotation;
        //public Transform m_Orientation;
		public PlayerModel(PlayerDataSO _playerDataSO)
        {
            m_Speed = _playerDataSO.Speed;
            //m_MouseRotation = _playerDataSO.MouseRotation;
            //m_Orientation = _playerDataSO.Orientation;
            //m_RotationSensitivity = _playerDataSO.RotationSensitivity;
        }
    }
}
