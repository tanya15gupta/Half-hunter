using System;
using UnityEngine;

namespace HalfHunter.Player
{
    public class PlayerGroundCheck : MonoBehaviour
    {
		public bool IsGrounded { get; private set; }
		private void OnTriggerEnter(Collider other)
		{
			IsGrounded = true;
		}
		private void OnTriggerExit(Collider other)
		{
			IsGrounded = false;
		}
	}
}
