using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Project3_Interface;
using DeviceManagement_WebApp.Project3_Repo_s;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Project3_Repo_s
{
    public class RepoZones : RepoGenerics<Zone>, ZoneInterface
    {
        public RepoZones(ConnectedOfficeContext context) : base(context)
        {
        }

        public new List<Zone> GetAll()
        {
            return GetAll(_context);
        }

        public List<Zone> GetAll(ConnectedOfficeContext _context)
        {
            return _context.Zone.ToList();
        }
    }
}
