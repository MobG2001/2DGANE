using UnityEngine;

namespace Mob
{
    /// <summary>
    /// ���a�o�g�t��
    /// </summary>
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }
    }
}

