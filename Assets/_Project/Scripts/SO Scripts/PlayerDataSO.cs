using UnityEngine;

namespace HalfHunter
{
    [CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Player Scriptable Object", order = 1)]
    public class PlayerDataSO : ScriptableObject
    {
		[SerializeField] private float m_Speed;
		[SerializeField] private float m_JumpHeight;

		public float Speed { get { return m_Speed; } }
		public float JumpHeight { get { return m_JumpHeight; } }
	}
}
