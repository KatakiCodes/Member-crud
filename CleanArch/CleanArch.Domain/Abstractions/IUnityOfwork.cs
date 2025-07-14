using System;

namespace CleanArch.Domain.Abstractions;

public interface IUnityOfwork
{
    public Task CommitAsync();
    public void RollBack();
}
