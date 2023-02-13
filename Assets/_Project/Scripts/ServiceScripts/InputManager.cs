using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HalfHunter.Player
{
    public class InputManager : MonoSingleton<InputManager>
    {
        [SerializeField] private float m_Sensitivity;
        [SerializeField] private float m_Smoothening;
		private Vector2 m_SmootheMouseMovement;

		public Vector2 MouseAxisInput()
        {
            Vector2 mouseMovement;
            mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y") * Time.deltaTime * m_Sensitivity);
            m_SmootheMouseMovement.x = Mathf.Lerp(m_SmootheMouseMovement.x, mouseMovement.x, 1f/m_Smoothening);
            m_SmootheMouseMovement.y = Mathf.Lerp(m_SmootheMouseMovement.y, mouseMovement.y, 1f/m_Smoothening);
			return mouseMovement;
		}

        public Vector2 MovementInput()
        {
			Vector2 m_MovementInput;
			m_MovementInput.x = Input.GetAxis("Horizontal");
            m_MovementInput.y = Input.GetAxis("Vertical");
            return m_MovementInput;
        }

        public bool IsJumpKeyPressed()
        {
            if(Input.GetAxis("Jump") > 0)
                return true;
            return false;
        }

    }
}
