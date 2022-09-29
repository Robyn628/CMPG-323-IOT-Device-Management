using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Project3_Interface
{
    public interface DeviceInterface : GenericInterface<Device>
    {
        public Task<Device> Details(Guid id);
        public IIncludableQueryable<Device, Zone> Use();
    }
}
