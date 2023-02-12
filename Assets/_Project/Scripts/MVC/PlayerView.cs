using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfHunter.Player
{ 
    public class PlayerView : MonoBehaviour
    {
        private PlayerController m_PlayerController;
		private void Update()
		{
			m_PlayerController.RotateCamera();
		}
		public void SetController(PlayerController _playerController)
        {
            m_PlayerController = _playerController;
        }
    }
}
