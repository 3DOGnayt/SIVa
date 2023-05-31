using Ecs.Extensions.UidGenerator;
using JCMG.EntitasRedux;

namespace Ecs.Scheduler.Components
{
    [Scheduler]
    public class TimeScaleTargetComponent : IComponent
    {
        public Uid Value;
    }
}