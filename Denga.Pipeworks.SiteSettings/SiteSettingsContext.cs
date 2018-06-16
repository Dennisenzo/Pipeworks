using System.Collections.Generic;
using System.Text;
using Denga.Pipeworks.Data;
using Microsoft.EntityFrameworkCore;

namespace Denga.Pipeworks.SiteSettings.Data
{
    public  class SiteSettingsContext : PipeworksContext<SiteSettingsContext>
    {
        public DbSet<SiteSettingsGroup> SiteSettingsGroups { get; set; }
        public DbSet<SiteSettingsGroupSiteSetting> SiteSettingsGroupSiteSettings { get; set; }
        public DbSet<SiteSetting> SiteSettings { get; set; }

        public SiteSettingsContext(DbContextOptions<SiteSettingsContext> settings):base(settings)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteSettingsGroupSiteSetting>()
                .HasKey(sgs => new {sgs.SettingId, sgs.SettingsGroupId});

            modelBuilder.Entity<SiteSettingsGroupSiteSetting>()
                .HasOne(sgs => sgs.Setting)
                .WithMany(ss => ss.SettingsGroupSettings)
                .HasForeignKey(ou => ou.SettingId);

            modelBuilder.Entity<SiteSettingsGroupSiteSetting>()
                .HasOne(sgs => sgs.SettingsGroup)
                .WithMany(sg => sg.SettingsGroupSettings)
                .HasForeignKey(ou => ou.SettingsGroupId);
        }
    }
}
