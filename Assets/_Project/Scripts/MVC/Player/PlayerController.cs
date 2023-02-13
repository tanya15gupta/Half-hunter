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
		private Vector3 m_MoveDirection;
		private Vector2 m_MousePosition;
		private InputManager m_InputManager;
		private Transform m_PlayerTransform;
		public PlayerController(PlayerModel _playerModel, PlayerView _playerView)
		{
			Cursor.lockState = CursorLockMode.Locked;
			m_PlayerModel = _playerModel;
			m_PlayerView = GameObject.Instantiate<PlayerView>(_playerView);
			m_PlayerView.SetController(this);
			m_InputManager = InputManager.Instance;
			m_PlayerTransform = m_PlayerView.gameObject.transform;
		}
		public void RotateCamera()
		{
			m_Movement = m_InputManager.MouseAxisInput();
			m_MousePosition += m_Movement;
			m_MousePosition.y = Mathf.Clamp(m_Movement.y, -90, 90);
			m_PlayerTransform.localRotation = Quaternion.Euler(-m_MousePosition.y, m_MousePosition.x, 0);
		}

		public void MovePlayer()
		{
			m_MoveDirection = m_PlayerTransform.forward * m_InputManager.MovementInput().y + m_PlayerTransform.right * m_InputManager.MovementInput().x;
			m_PlayerView.transform.position += m_MoveDirection * m_PlayerModel.Speed * Time.fixedDeltaTime;
		}

		public void PlayerJump()
		{
			if(m_PlayerView.IsPlayerGrounded())
			{
				if(m_InputManager.IsJumpKeyPressed())
					m_PlayerView.GetRigidBody().AddForce(m_PlayerTransform.up * m_PlayerModel.JumpHeight, ForceMode.Impulse);
			}
		}
	}
}

