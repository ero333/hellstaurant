using System.Collections;
using System.Collections.Generic;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using Unity.Services.Core.Environments;

public class InitWithDefault : MonoBehaviour
{
    async void Start()
    {
            var options = new InitializationOptions();
            options.SetEnvironmentName("bonsignore-final-tadd4");
            await UnityServices.InitializeAsync(options);

            AnalyticsService.Instance.StartDataCollection();
    }
}