# Community .NET package for PostHog

## Build 

[![CircleCI](https://dl.circleci.com/status-badge/img/gh/Gamefound/PostHog.NET/tree/master.svg?style=svg)](https://dl.circleci.com/status-badge/redirect/gh/Gamefound/PostHog.NET/tree/master)

## Get Package

You can get PostHog.NET by [grabbing the latest NuGet package](https://www.nuget.org/packages/PostHog.NET).

## Get Started
Register the service
```
services.AddPostHog("api-key", config =>
            {
                // leave empty if you are not self-hosting 
                config.Host = "example.com";
            });
```

Inject IPostHogClient 
```
private readonly IPostHogClient _postHogClient;

public WeatherForecastController(IPostHogClient postHogClient)
{
    _postHogClient = postHogClient;
}
```
then call a desired method
```
var properties = new Properties()
                .SetEventProperty("event", "value")
                .SetUserProperty("user-property-to-set", "value") // $set equivalent
                .SetUserPopertyOnce("user-property-to-set-once", "value"); // $set_once equivalent

_postHogClient.Capture("a86818cc-c84e-4453-9c48-d7bb636e7f2d", "Fetch weather forecast", properties);
```

## Thanks

This library is largely based on the [Analytics.NET](https://github.com/segmentio/Analytics.NET) package.
