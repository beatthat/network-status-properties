using BeatThat.OptionalComponents;
using BeatThat.StateControllers;

namespace BeatThat.NetworkStatus.Properties
{
    [OptionalComponent(typeof(BindHasNetworkError))]
    public class HasNetworkError : BoolStateProperty {}
}

