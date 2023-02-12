using HalfHunter.Player;
using UnityEngine;

namespace HalfHunter
{
    public class PlayerService : MonoSingleton<PlayerService>
    {
        [SerializeField] private PlayerView m_PlayerPrefab;
        [SerializeField] private PlayerDataSO m_PlayerData;
        [SerializeField] private PlayerController m_PlayerController;
		private void Start()
		{
			m_PlayerController = new PlayerController(new PlayerModel(m_PlayerData), m_PlayerPrefab);
		}
	}
}
