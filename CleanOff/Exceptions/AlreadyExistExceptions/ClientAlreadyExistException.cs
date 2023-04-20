﻿using CleanOff.Domain;

namespace CleanOff.Exceptions.AlreadyExistExceptions;

public class ClientAlreadyExistException : AlreadyExistException<Client>
{
    public ClientAlreadyExistException(Client client) : base(client)
    {
    }

    public override string Message => $"Пользователь с электронной почтой уже существует: {_item.Email}";
}