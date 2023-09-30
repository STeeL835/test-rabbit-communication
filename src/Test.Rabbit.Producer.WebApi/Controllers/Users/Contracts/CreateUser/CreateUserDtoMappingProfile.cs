﻿using Test.Rabbit.Producer.App.Users.CreateUser.Parameters;

namespace Test.Rabbit.Producer.WebApi.Controllers.Users.Contracts.CreateUser;

// TODO: tests on profiles validation
// TODO: register mediatr
public class CreateUserDtoMappingProfile : AutoMapper.Profile 
{
    public CreateUserDtoMappingProfile()
    {
        CreateMap<CreateUserDto, CreateUserCommand>();
    }
}