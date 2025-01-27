using Unity.Entities;

public partial class CubeMoveSystem : SystemBase
{
    protected override void OnUpdate()
    {
        Entities.ForEach(() => { }).Schedule();
    }
}