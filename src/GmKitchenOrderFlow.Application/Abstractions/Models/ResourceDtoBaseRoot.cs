﻿namespace GmKitchenOrderFlow.Application.Models.Abstractions;

public class ResourceDtoBaseRoot<TKey> : ResourceDtoBase
{
    public TKey Id { get; set; }
}
