﻿global using Conf = FastEndpoints.Config;

namespace FastEndpoints.Swagger;

/// <summary>
/// gives access to the fastendpoints global configuration settings
/// </summary>
public static class GlobalConfig
{
    /// <summary>
    /// the prefix used in front of the version (for example 'v' produces 'v{version}').
    /// </summary>
    public static string? VersioningPrefix => Conf.VerOpts.Prefix;

    /// <summary>
    /// prefix for all routes (example 'api').
    /// </summary>
    public static string? EndpointRoutePrefix => Conf.EpOpts.RoutePrefix;
}
