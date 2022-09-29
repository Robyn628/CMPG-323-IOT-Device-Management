using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Project3_Interface;
using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Project3_Repo_s;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Project3_Repo_s
{
    public class RepoDevices : RepoGenerics<Device>, DeviceInterface
    {
        public RepoDevices(ConnectedOfficeContext context) : base(context)
        {
        }

        public List<Device> GetAll(ConnectedOfficeContext _context)
        {
            return _context.Device.ToList();
        }

        public new List<Device> GetAll()
        {
            return GetAll(_context);
        }
                
        public IIncludableQueryable<Device,Zone> Use()
        {
            return _context.Device.Include(d => d.Category).Include(d => d.Zone);
        }

        public Task<Device> Details(Guid id)
        {
            var device = _context.Device.Include(d => d.Category).Include(d => d.Zone).FirstOrDefaultAsync(m => m.DeviceId == id);
            return device;
        }
    }
}
