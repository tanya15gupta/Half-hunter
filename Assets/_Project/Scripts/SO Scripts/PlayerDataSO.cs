using UnityEngine;

namespace HalfHunter
{
    [CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Player Scriptable Object", order = 1)]
    public class PlayerDataSO : ScriptableObject
    {
		[SerializeField] private float m_Speed;
		//[SerializeField] private float m_RotationSensitivity;
		//[SerializeField] private Vector2 m_MouseRotation;
		//[SerializeField] private Transform m_Orientation;

		public float Speed { get { return m_Speed; } }
		//public float RotationSensitivity { get { return m_RotationSensitivity; } }
		//public Transform Orientation { get { return m_Orientation; } }
		//public Vector2 MouseRotation { get { return m_MouseRotation; } }
	
	}
}
