using System.Collections.Generic;
using BeatThat.DependencyInjection;
using BeatThat.Properties;
using BeatThat.StateStores;

namespace BeatThat.NetworkStatus.Properties
{
    public class BindHasNetworkError : UpdatesPropertyOnNotifications<HasNetworkError, bool>
    {
        protected override void GetUpdateNotifications(ICollection<string> notifications)
        {
            notifications.Add(State<NetworkStatusData>.UPDATED);
        }

        protected override bool authoritativeValue
        {
            get
            {
                return this.networkStatus.stateData.hasNetworkError;
            }
        }

        [Inject] HasState<NetworkStatusData> networkStatus { get; set; }
    }
}

