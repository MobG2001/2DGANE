using UnityEngine;

/// <summary>
/// �ˮ`�t��
/// </summary>
namespace Mob
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�z���w�s��")]
        private GameObject prefabExplosion;
        [SerializeField, Header("�I��|�z�����W��")]
        private string nameTarget;
    }

}
