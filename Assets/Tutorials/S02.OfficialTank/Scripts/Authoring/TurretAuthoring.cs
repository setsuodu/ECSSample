using Unity.Entities;

// Authoring MonoBehaviours are regular GameObject components.
// They constitute the inputs for the baking systems which generates ECS data.
class TurretAuthoring : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject CannonBallPrefab;
    public UnityEngine.Transform CannonBallSpawn;
}

// Bakers convert authoring MonoBehaviours into entities and components.
class TurretBaker : Baker<TurretAuthoring>
{
    public override void Bake(TurretAuthoring authoring)
    {
        // �Ķ���
        //AddComponent<Turret>();
        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new Turret());

        // �Ķ��� TransformUsageFlags ��� GetEntity(authoring.xxxEntity)
        AddComponent(entity, new Turret()
        {
            CannonBallPrefab = GetEntity(authoring.CannonBallPrefab, TransformUsageFlags.Dynamic),
            CannonBallSpawn = GetEntity(authoring.CannonBallSpawn, TransformUsageFlags.Dynamic)
        });
    }
}