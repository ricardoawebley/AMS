using AssetManagementApplication.Server.Models;
using AssetManagementApplication.Shared.DomainModels;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagementApplication.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Acquisition> Acquisitions { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Transfer> Transfers { get; set; }

    }
}
