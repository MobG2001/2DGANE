using UnityEngine;

namespace Mob
{
    /// <summary>
    /// �o�g�t�ΰ�
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullets;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointspawn;

        protected void SpawnBullet()
        {
            Instantiate(prefabBullets, pointspawn.position, pointspawn.rotation);
        }
    }
}

