using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfHunter.Player
{ 
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Rigidbody m_PlayerRigidBody;
        [SerializeField] private PlayerGroundCheck m_PlayerGroundCheck;
        private PlayerController m_PlayerController;

		private void Start()
		{
			m_PlayerRigidBody = GetComponent<Rigidbody>();
		}

		private void Update()
		{
            m_PlayerController.RotateCamera();
		}
		private void FixedUpdate()
		{
			m_PlayerController.MovePlayer();
			m_PlayerController.PlayerJump();
		}
		public Rigidbody GetRigidBody() => m_PlayerRigidBody;
        public bool IsPlayerGrounded() => m_PlayerGroundCheck.IsGrounded;
		public void SetController(PlayerController _playerController)
        {
            m_PlayerController = _playerController;
        }
    }
}
