using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfHunter.Player
{
	public class PlayerController
	{
		private PlayerModel m_PlayerModel;
		private PlayerView m_PlayerView;
		private Vector2 m_Movement;
		private Vector2 m_MousePosition;
		private InputManager m_InputManager;
		public PlayerController(PlayerModel _playerModel, PlayerView _playerView)
		{
			Cursor.lockState = CursorLockMode.Locked;
			m_PlayerModel = _playerModel;
			m_PlayerView = GameObject.Instantiate<PlayerView>(_playerView);
			m_PlayerView.SetController(this);
			m_InputManager = InputManager.Instance;

		}
		public void RotateCamera()
		{
			/*m_PlayerModel.m_MouseRotation = m_InputManager.MouseAxisInput() * m_PlayerModel.m_RotationSensitivity;
			m_Movement.x -= m_PlayerModel.m_MouseRotation.y;
			m_Movement.y += m_PlayerModel.m_MouseRotation.x;*/
			//m_PlayerView.gameObject.transform.rotation = Quaternion.Euler(m_Movement);
			//m_PlayerView.gameObject.transform.localRotation = Quaternion.Euler(-m_Movement.y, m_Movement.x, 0);
			m_Movement = m_InputManager.MouseAxisInput();
			m_MousePosition += m_Movement;
			m_MousePosition.y = Mathf.Clamp(m_Movement.y, -90, 90);
			m_PlayerView.gameObject.transform.localRotation = Quaternion.Euler(-m_MousePosition.y, m_MousePosition.x, 0);
		}
	}
}

