using Bindito.Core;
using WeatherTypeGetterInterface;
using Timberborn.ModManagerScene;
using UnityEngine;

namespace MW_compat_SFC
{
    public class MW_compat_SFC : IModStarter
    {
        public void StartMod(IModEnvironment modEnvironment)
        {
            Debug.unityLogger.Log("ModdableWeathers compat for SimpleFloodgateTriggers - started");
        }
    }

    [Context("Game")]
    public class MW_SF_Configurator: Configurator
    {
        protected override void Configure()
        {
            this.RemoveBinding<IWeatherTypeGetter>();
            this.BindSingleton<IWeatherTypeGetter, MW_WeatherTypeGetter>();
        }
    }
}
