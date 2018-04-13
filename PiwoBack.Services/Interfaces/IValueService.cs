using System;
using System.Collections.Generic;
using System.Text;
using PiwoBack.Data.Models;

namespace PiwoBack.Services.Interfaces
{
    public interface IValueService
    {
        IEnumerable<Value> GetAll();
        Value GetValue(int id);
    }
}
