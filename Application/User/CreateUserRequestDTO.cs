using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User
{
    public class CreateUserRequestDTO
    {
        public IFormFile File { get; set; }
    }
}
