using FloatDoor.Application.InputModels;
using FloatDoor.Application.ViewModels;
using FloatDoor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDoor.Application.Services.Interfaces
{
    public interface IFloatService 
    {
        List<FloatsViewModel> GetAllFloats();
        FloatDetailsViewModel GetFloatById(int id);
        int CreateFloat(CreateFloatInputModel inputModel);
        void UpdateFloat(UpdateFloatInputModel inputModel);
        void DeleteFloat(int id);
        void Request(int id);
        void Approve(int id);
        void Reject(int id);        
    }
}
