﻿using Cafe.DI.Interfaces.Models;

namespace Cafe.DI.UserInterfaces
{
    /// <summary>
    /// Interface describing the behavior of the client.
    /// </summary>
    public interface IClient: IPerson
    {
        int Id { get; }
        int Balance { get; }
        IMeal Meal { get; }

        void PutMoney(int amount);
        IMeal CreateOrder();
    }
}