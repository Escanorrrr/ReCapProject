using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        DataResult<List<User>> GetAll();
        
        User GetByMail(string email);
        List<OperationClaim> GetClaims(User user);

    }
}
