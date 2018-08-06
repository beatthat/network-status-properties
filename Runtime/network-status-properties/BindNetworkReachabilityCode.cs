using System.Collections.Generic;
using BeatThat.DependencyInjection;
using BeatThat.Properties;
using BeatThat.StateStores;
using UnityEngine;

namespace BeatThat.NetworkStatus.Properties
{
    public class BindNetworkReachabilityCode : UpdatesPropertyOnNotifications<NetworkReachabilityCode, int>
    {
        protected override void GetUpdateNotifications(ICollection<string> notifications)
        {
            notifications.Add(State<NetworkStatusData>.UPDATED);
        }

        protected override int authoritativeValue
        {
            get
            {
                switch(this.networkStatus.stateData.networkReachability) {
                    case NetworkReachability.NotReachable:
                        return 0;
                    case NetworkReachability.ReachableViaCarrierDataNetwork:
                        return 1;
                    case NetworkReachability.ReachableViaLocalAreaNetwork:
                        return 2;
                    default:
                        return 0;
                }
            }
        }

        [Inject] HasState<NetworkStatusData> networkStatus { get; set; }
    }
}

