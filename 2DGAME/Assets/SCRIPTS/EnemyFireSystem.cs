using UnityEngine;

namespace Mob
{
    /// <summary>
    /// �ĤH�o�g�t��
    /// </summary>
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("�ͦ��l�u���j"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}
