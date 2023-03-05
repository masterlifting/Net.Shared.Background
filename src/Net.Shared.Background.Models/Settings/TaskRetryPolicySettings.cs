﻿namespace Net.Shared.Background.Models.Settings;

public sealed record TaskRetryPolicySettings
{
    public int EveryTime { get; init; } = 5;
    public int MaxAttempts { get; init; } = 10;
}