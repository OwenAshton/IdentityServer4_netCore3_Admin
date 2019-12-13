using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using UsersAPI.Common.Dtos;

namespace UsersAPI.Application.Users.Queries.GetUserById
{
    public class GetUserByIdQuery: IRequest<UserDto>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
