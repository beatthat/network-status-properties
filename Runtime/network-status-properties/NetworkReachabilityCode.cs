using BeatThat.OptionalComponents;
using BeatThat.StateControllers;

namespace BeatThat.NetworkStatus.Properties
{
    [OptionalComponent(typeof(BindNetworkReachabilityCode))]
    public class NetworkReachabilityCode : IntStateProperty {}
}

